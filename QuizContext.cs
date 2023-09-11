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

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<UserTestQuestionAnswer> UserTestQuestionAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
        }

        }
}
