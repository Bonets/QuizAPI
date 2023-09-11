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
    }
}
