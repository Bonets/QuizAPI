using QuizAPI.Core;
using QuizAPI.DTO;

namespace QuizAPI.Services.Interfaces
{
    public interface IAnswerService
    {
        public Task<ServiceResult<int>> TryAddUserAnswer(UserAnswerDTO model);

    }
}
