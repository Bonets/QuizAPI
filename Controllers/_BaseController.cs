using Microsoft.AspNetCore.Mvc;
using QuizAPI;
using QuizAPI.Core;
using QuizAPI.Services;

namespace QuizAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class _BaseController : ControllerBase
    {
        protected IServiceFactory _serviceFactory;
        protected QuizContext _quizContext;

        public _BaseController(IServiceFactory serviceFactory, QuizContext quizContext)
        {
            _serviceFactory = serviceFactory;
            _quizContext = quizContext;
        }

        protected async Task<IActionResult> GetResponse(ServiceResult serviceResult)
        {
            if (serviceResult.Success)
            {
                return Ok(serviceResult);
            }
            else if (serviceResult.HttpStatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound(serviceResult);
            }
            else if (serviceResult.HttpStatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                return Problem("Si è verificato un errore");
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }
    }
}
