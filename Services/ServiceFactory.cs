using QuizAPI.Services.Implementations;
using QuizAPI.Services.Interfaces;

namespace QuizAPI.Services
{
    public class ServiceFactory : IServiceFactory
    {
        protected QuizContext _context;
        public ServiceFactory(QuizContext context)
        {
            _context = context;
        }

        public IAnswerService CreateAnswerService(QuizContext context)
        {
            return new AnswerService(context);
        }

        public IQuestionService CreateQuestionService(QuizContext context)
        {
            return new QuestionService(context);
        }

        public ITestService CreateTestService(QuizContext context)
        {
            return new TestService(context);
        }
    }
}
