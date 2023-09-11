using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizAPI;
using QuizAPI.Services;

namespace QuizAPI.Controllers
{
    public class UserController : _BaseController
    {
        protected IConfiguration _configuration;
        public UserController(IServiceFactory serviceFactory, QuizContext taskContext, IConfiguration configuration) : base(serviceFactory, taskContext)
        {
            _configuration = configuration;
        }
    }
}