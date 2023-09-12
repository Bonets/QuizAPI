using QuizAPI.Core;
using QuizAPI.DTO;

namespace QuizAPI.Services.Interfaces
{
    public interface IQuestionService
    {
        public Task<ServiceResult<List<QuestionDTO>>> TryGetTestQuestions(int testId);

    }
}
