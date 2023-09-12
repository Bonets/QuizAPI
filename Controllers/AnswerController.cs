using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizAPI;
using QuizAPI.DTO;
using QuizAPI.Services;

namespace QuizAPI.Controllers
{
    public class AnswerController : _BaseController
    {
        protected IConfiguration _configuration;
        public AnswerController(IServiceFactory serviceFactory, QuizContext taskContext, IConfiguration configuration) : base(serviceFactory, taskContext)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Saves user answer in database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> TryInsertNewUserAnswer(UserAnswerDTO model)
        {
            var result = await _serviceFactory.CreateAnswerService(_quizContext).TryAddUserAnswer(model);
            return await GetResponse(result);
        }
    }
}