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
        protected QuizContext _taskContext;

        public _BaseController(IServiceFactory serviceFactory, QuizContext taskContext)
        {
            _serviceFactory = serviceFactory;
            _taskContext = taskContext;
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
