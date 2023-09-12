using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;
using System.Data.SqlTypes;

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

            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    UserId = 1,
                    UserName = "Alessia"
                },
                new User
                {
                    UserId = 2,
                    UserName = "Luigi"
                });

            modelBuilder.Entity<Test>()
                .HasData(
                new Test
                {
                    TestId = 1,
                    Description = "Volleyball",
                },
                new Test
                {
                    TestId = 2,
                    Description = "Formula 1",
                },
                new Test
                {
                    TestId = 3,
                    Description = "Numbers",
                });

            modelBuilder.Entity<Question>()
                .HasData(
                new Question
                {
                    TestId = 1,
                    QuestionId = 1,
                    Description = "How large is a volleyball court?",
                },
                new Question
                {
                    TestId = 1,
                    QuestionId = 2,
                    Description = "Can you touch the ball with your feet?",
                },
                new Question
                {
                    TestId = 1,
                    QuestionId = 3,
                    Description = "How many points does a set have?",
                },
                new Question
                {
                    TestId = 1,
                    QuestionId = 4,
                    Description = "What is the winning formula in a standard match??",
                },
                new Question
                {
                    QuestionId = 5,
                    TestId = 2,
                    Description = "Which city hosts the Monaco Grand Prix?",
                },
                new Question
                {
                    QuestionId = 6,
                    TestId = 2,
                    Description = "Which F1 constructor is based in Milton Keynes, England?",
                },
                new Question
                {
                    QuestionId = 7,
                    TestId = 2,
                    Description = "What is the name of the F1 car's protective structure that is designed to protect the driver's head in the event of an accident?",
                },
                new Question
                {
                    QuestionId = 8,
                    TestId = 2,
                    Description = "“The Iceman” is the nickname given to which Finnish Formula 1 World Champion??",
                },
                new Question
                {
                    QuestionId = 9,
                    TestId = 3,
                    Description = "How many minutes are in a full week?",
                },
                new Question
                {
                    QuestionId = 10,
                    TestId = 3,
                    Description = "How many elements are in the periodic table?",
                },
                new Question
                {
                    QuestionId = 11,
                    TestId = 3,
                    Description = "How many bones do we have in an ear?",
                },
                new Question
                {
                    QuestionId = 12,
                    TestId = 3,
                    Description = "How many faces does a Dodecahedron have?",
                });

            modelBuilder.Entity<Answer>()
                .HasData(
                new Answer
                {
                    QuestionId = 3,
                    AnswerId = 1,
                    Description = "17"
                },
                new Answer
                {
                    QuestionId = 3,
                    AnswerId = 2,
                    Description = "21"
                },
                new Answer
                {
                    QuestionId = 3,
                    AnswerId = 3,
                    Description = "25",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 4,
                    AnswerId = 5,
                    Description = "Best of 3"
                },
                new Answer
                {
                    QuestionId = 4,
                    AnswerId = 6,
                    Description = "Best of 5",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 4,
                    AnswerId = 7,
                    Description = "Best of 7"
                },
                 new Answer
                 {
                     QuestionId = 1,
                     AnswerId = 8,
                     Description = "8x8",
                 },
                new Answer
                {
                    QuestionId = 1,
                    AnswerId = 9,
                    Description = "9x9",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 1,
                    AnswerId = 10,
                    Description = "7x7"
                },
                new Answer
                {
                    QuestionId = 2,
                    AnswerId = 11,
                    Description = "Yes",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 2,
                    AnswerId = 12,
                    Description = "No"
                },
                new Answer
                {

                    QuestionId = 5,
                    AnswerId = 13,
                    Description = "Monte Carlo",
                    IsRightAnswer = true
                },
                new Answer
                {

                    QuestionId = 5,
                    AnswerId = 14,
                    Description = "Rome"
                },
                new Answer
                {
                    QuestionId = 5,
                    AnswerId = 15,
                    Description = "Budapest"
                },
                new Answer
                {
                    QuestionId = 6,
                    AnswerId = 16,
                    Description = "Red Bull Racing",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 6,
                    AnswerId = 17,
                    Description = "Aston Martin",
                },
                new Answer
                {
                    QuestionId = 6,
                    AnswerId = 18,
                    Description = "Sauber"
                },
                new Answer
                {
                    QuestionId = 8,
                    AnswerId = 19,
                    Description = "Valtteri Bottas"
                },
                new Answer
                {
                    QuestionId = 8,
                    AnswerId = 20,
                    Description = "Kimi Räikkönen",
                    IsRightAnswer = true
                },
                 new Answer
                 {
                     QuestionId = 7,
                     AnswerId = 21,
                     Description = "Halo",
                     IsRightAnswer = true
                 },
                new Answer
                {
                    QuestionId = 7,
                    AnswerId = 22,
                    Description = "Fuel sensor"
                },
                 new Answer
                 {
                     QuestionId = 9,
                     AnswerId = 23,
                     Description = "10080",
                     IsRightAnswer = true
                 },
                new Answer
                {
                    QuestionId = 9,
                    AnswerId = 24,
                    Description = "10820"
                },
                new Answer
                {
                    QuestionId = 9,
                    AnswerId = 25,
                    Description = "11800"
                },
                new Answer
                {
                    QuestionId = 10,
                    AnswerId = 26,
                    Description = "118",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 10,
                    AnswerId = 27,
                    Description = "120"
                },
                new Answer
                {
                    QuestionId = 11,
                    AnswerId = 28,
                    Description = "3",
                    IsRightAnswer = true
                },
                new Answer
                {
                    QuestionId = 11,
                    AnswerId = 29,
                    Description = "4",
                },
                new Answer
                {
                    QuestionId = 11,
                    AnswerId = 30,
                    Description = "5"
                },
                new Answer
                {
                    QuestionId = 12,
                    AnswerId = 31,
                    Description = "16"
                },
                new Answer
                {
                    QuestionId = 12,
                    AnswerId = 32,
                    Description = "20"
                },
                new Answer
                {
                    QuestionId = 12,
                    AnswerId = 33,
                    Description = "12",
                    IsRightAnswer = true
                }
            );
        }

    }
}
