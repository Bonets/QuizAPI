namespace QuizAPI.DTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public string QuestionDescription { get; set; }
        public List<AnswerDTO> Answers { get; set; }
        public Guid UserTestGuid { get; set; }
    }
}
