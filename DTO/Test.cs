namespace QuizAPI.DTO
{
    public class TestDTO
    {
        public int TestId { get; set; }
        public string Title { get; set; }
        
    }

    public class TestQuestionsDTO : TestDTO
    {
        public List<int> QuestionId { get; set; }
    }
}
