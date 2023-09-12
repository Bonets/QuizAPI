namespace QuizAPI.DTO
{
    public class AnswerDTO
    {
        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
    }

    public class UserAnswerDTO
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int TestResultId
        {
            get; set;
        }
    }
}
