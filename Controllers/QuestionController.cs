using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizAPI;
using QuizAPI.Services;

namespace QuizAPI.Controllers
{
    public class QuestionController : _BaseController
    {
        protected IConfiguration _configuration;
        public QuestionController(IServiceFactory serviceFactory, QuizContext taskContext, IConfiguration configuration) : base(serviceFactory, taskContext)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("{testId}")]
        public async Task<IActionResult> TryGetTests(int testId)
        {
            var result = await _serviceFactory.CreateQuestionService(_quizContext).TryGetTestQuestions(testId);
            return await GetResponse(result);
        }
    }
}