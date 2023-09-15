using Microsoft.EntityFrameworkCore;
using QuizAPI;
using QuizAPI.Services.Implementations;
using QuizAPI.Services.Interfaces;

namespace QuizAPI.Services
{
    public interface IServiceFactory
    {
        public IQuizService CreateTestService(QuizContext context);
        public IQuestionService CreateQuestionService(QuizContext context);
        public IAnswerService CreateAnswerService(QuizContext context);
    }
}
