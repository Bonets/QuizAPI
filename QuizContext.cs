using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;

namespace QuizAPI
{
    public class QuizContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public QuizContext(DbContextOptions<QuizContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = _configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<User> User { get; set; }

    }
}
