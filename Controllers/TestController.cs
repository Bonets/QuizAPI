using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizAPI;
using QuizAPI.Services;

namespace QuizAPI.Controllers
{
    public class TestController : _BaseController
    {
        protected IConfiguration _configuration;
        public TestController(IServiceFactory serviceFactory, QuizContext quizContext, IConfiguration configuration) : base(serviceFactory, quizContext)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> TryGetTests()
        {
            var result = await _serviceFactory.CreateTestService(_quizContext).TryGetTestList();
            return await GetResponse(result);
        }

        [HttpPost]
        [Route("new/{userId}/{testId}")]
        public async Task<IActionResult> TryCreateTestResult(int userId, int testId)
        {
            var result = await _serviceFactory.CreateTestService(_quizContext).TryCreateTestResult(userId, testId);
            return await GetResponse(result);
        }
    }
}