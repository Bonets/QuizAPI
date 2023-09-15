using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.IdentityModel.Tokens;
using QuizAPI.Core;
using QuizAPI.DTO;
using QuizAPI.Models;
using QuizAPI.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QuizAPI.Services.Implementations
{
    public class QuizService : IQuizService
    {
        protected QuizContext _context;
        public QuizService(QuizContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<int>> TryCalculateTestResult(int testResultId)
        {
            try
            {
                var result = new ServiceResult<int>();
                var answers = await _context.UserTestQuestionAnswers
                    .Include(x => x.Answer)
                    .Include(x => x.TestResult)
                    .ThenInclude(y => y.User)
                    .Include(x => x.TestResult)
                    .ThenInclude(y => y.Test)
                    .Where(x => x.TestResultId == testResultId)
                    .ToListAsync();

                if (answers.Count() == 0)
                {
                    return result.NotFoundResult("Test non trovato");
                }
                else
                {
                    var _dbtestResult = answers.FirstOrDefault().TestResult;
                    _dbtestResult.RightAnswers = answers.Where(x => x.Answer.IsRightAnswer).Count();
                    _dbtestResult.TotalAnswers = answers.Count();

                    _context.Entry(_dbtestResult).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                return result;
            }
            catch (Exception e)
            {
                return new ServiceResult<int>().ExceptionResult();
            }
        }


        public async Task<ServiceResult<int>> TryCreateTestResult(int userId, int testId)
        {
            try
            {
                var result = new ServiceResult<int>();
                var testResult = new Models.TestResult
                {
                    TestId = testId,
                    UserId = userId,
                };

                _context.Entry(testResult).State = EntityState.Added;
                await _context.SaveChangesAsync();

                result.ResponseData = testResult.TestResultId;

                return result;
            }
            catch (Exception e)
            {
                return new ServiceResult<int>().ExceptionResult();
            }
        }

        public async Task<ServiceResult<List<TestDTO>>> TryGetTestList()
        {
            try
            {
                var result = new ServiceResult<List<TestDTO>>();
                var tests = await _context.Tests.Select(x => new TestDTO
                {
                    TestId = x.TestId,
                    Title = x.Description,
                }).ToListAsync();

                result.ResponseData = new List<TestDTO>();
                result.ResponseData = tests.OrderBy(x => x.TestId).ToList();

                return result;
            }
            catch (Exception e)
            {
                return new ServiceResult<List<TestDTO>>().ExceptionResult();
            }
        }

        public async Task<ServiceResult<TestResultDTO>> TryGetTestResult(int testResultId)
        {
            try
            {
                var result = new ServiceResult<TestResultDTO>();
                var testResult = await _context.TestResults
                    .Where(x => x.TestResultId == testResultId)
                    .Include(x => x.Test)
                    .Include(x => x.User)
                    .Select(x => new TestResultDTO
                    {
                        TestId = x.TestId,
                        Description = x.Test.Description,
                        RightAnswers = x.RightAnswers,
                        TotalAnswers = x.TotalAnswers,
                        UserId = x.UserId,
                        UserName = x.User.UserName

                    }).FirstOrDefaultAsync();
                if (testResult == null)
                {
                    return result.NotFoundResult("Test non trovato");
                }
                else
                {
                    result.ResponseData = testResult;
                }
                return result;
            }
            catch (Exception e)
            {
                return new ServiceResult<TestResultDTO>().ExceptionResult();
            }
        }
    }
}
