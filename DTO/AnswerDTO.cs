namespace QuizAPI.DTO
{
    public class AnswerDTO
    {
        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
    }

    public class UserAnswerDTO
    {
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}
