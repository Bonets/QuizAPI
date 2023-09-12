using QuizAPI.Core;
using QuizAPI.DTO;

namespace QuizAPI.Services.Interfaces
{
    public interface ITestService
    {
        public Task<ServiceResult<List<TestDTO>>> TryGetTestList();
    }
}
