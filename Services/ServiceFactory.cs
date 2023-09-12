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
        public ITestService CreateTestService(QuizContext context)
        {
            return new TestService(_context);
        }
    }
}
