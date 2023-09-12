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
    public class QuestionService : IQuestionService
    {
        protected QuizContext _context;
        public QuestionService(QuizContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<List<QuestionDTO>>> TryGetTestQuestions(int testId)
        {
            try
            {
                var result = new ServiceResult<List<QuestionDTO>>();
                var tests = await _context.Questions
                    .Where(x => x.TestId == testId)
                    .Select(x => new QuestionDTO
                    {
                        QuestionId = x.QuestionId,
                        QuestionDescription = x.Description,
                        Answers = x.Answers.Select(y => new AnswerDTO
                        {
                            AnswerId = y.AnswerId,
                            AnswerDescription = y.Description
                        }).ToList()
                    }).ToListAsync();

                result.ResponseData = new List<QuestionDTO>();
                result.ResponseData = tests.OrderBy(x => x.QuestionId).ToList();

                return result;
            }
            catch (Exception e)
            {
                return new ServiceResult<List<QuestionDTO>>().ExceptionResult();
            }
        }
    }
}
