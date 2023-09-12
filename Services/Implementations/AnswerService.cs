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
    public class AnswerService : IAnswerService
    {
        protected QuizContext _context;
        public AnswerService(QuizContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<int>> TryAddUserAnswer(UserAnswerDTO model)
        {
            try
            {
                var result = new ServiceResult<int>();
                var UserTestQuestionAnswer = new Models.UserTestQuestionAnswer
                {
                    AnswerId = model.AnswerId,
                    QuestionId = model.QuestionId,
                    TestResultId = model.TestResultId,
                    AnswerDate = DateTime.UtcNow,
                };
                _context.Entry(UserTestQuestionAnswer).State = EntityState.Added;
                await _context.SaveChangesAsync();

                result.ResponseData = UserTestQuestionAnswer.UserTestQuestionAnswerId;
                return result;
            }
            catch (Exception e)
            {
                return new ServiceResult<int>().ExceptionResult();
            }

        }

    }
}
