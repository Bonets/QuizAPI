using QuizAPI.Core;
using QuizAPI.DTO;

namespace QuizAPI.Services.Interfaces
{
    public interface ITestService
    {
        public Task<ServiceResult<List<TestDTO>>> TryGetTestList();
        public Task<ServiceResult<int>> TryCreateTestResult(int userId, int testId);
        public Task<ServiceResult<int>> TryCalculateTestResult(int testResultId);

        public Task<ServiceResult<TestResultDTO>> TryGetTestResult(int testResultId);
    }
}
