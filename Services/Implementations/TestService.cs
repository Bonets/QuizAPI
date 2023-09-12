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
    public class TestService : ITestService
    {
        protected QuizContext _context;
        public TestService(QuizContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<List<TestDTO>>> TryGetTestList()
        {
            try
            {
                var result = new ServiceResult<List<TestDTO>>();
                var tests = await _context.Tests.Select(x => new TestDTO
                {
                    TestId = x.TestId,
                    Title = x.TestName
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
    }
}
