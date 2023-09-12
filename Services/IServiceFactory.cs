using Microsoft.EntityFrameworkCore;
using QuizAPI;
using QuizAPI.Services.Implementations;
using QuizAPI.Services.Interfaces;

namespace QuizAPI.Services
{
    public interface IServiceFactory
    {
        public ITestService CreateTestService(QuizContext context);
        public IQuestionService CreateQuestionService(QuizContext context);
        public IAnswerService CreateAnswerService(QuizContext context);
    }
}
