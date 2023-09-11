using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.IdentityModel.Tokens;
using QuizAPI.Models;
using QuizAPI.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QuizAPI.Services.Implementations
{
    public class UsersService : IUsersService
    {
        protected QuizContext _context;
        protected IConfiguration _configuration;
        public UsersService(QuizContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
    }
}
