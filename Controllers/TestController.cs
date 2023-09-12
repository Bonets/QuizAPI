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

        /// <summary>
        /// Get tests list with description
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> TryGetTests()
        {
            var result = await _serviceFactory.CreateTestService(_quizContext).TryGetTestList();
            return await GetResponse(result);
        }

        /// <summary>
        /// Create tests result in db
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="testId"></param>
        /// <returns>TestResultId: needs to be used when saving answer to connect answer with specific test of specific user</returns>
        [HttpPost]
        [Route("new/{userId}/{testId}")]
        public async Task<IActionResult> TryCreateTestResult(int userId, int testId)
        {
            var result = await _serviceFactory.CreateTestService(_quizContext).TryCreateTestResult(userId, testId);
            return await GetResponse(result);
        }

        /// <summary>
        /// Calculates the result of the test with TestResultId
        /// </summary>
        /// <param name="testResultId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{testResultId}/result")]
        public async Task<IActionResult> TryCalculateTestResultIdResult(int testResultId)
        {
            var result = await _serviceFactory.CreateTestService(_quizContext).TryCalculateTestResult(testResultId);
            return await GetResponse(result);
        }

        /// <summary>
        /// Gets the result of the test with TestResultId
        /// </summary>
        /// <param name="testResultId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{testResultId}/result")]
        public async Task<IActionResult> TryGetTestResult(int testResultId)
        {
            var result = await _serviceFactory.CreateTestService(_quizContext).TryGetTestResult(testResultId);
            return await GetResponse(result);
        }
    }
}