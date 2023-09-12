namespace QuizAPI.DTO
{
    public class TestResultDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int TestId { get; set; }
        public string Description { get; set; }
        public int RightAnswers { get; set; }
        public int TotalAnswers { get; set; }
        public decimal PercentageResult {
            get
            {
                return (decimal)RightAnswers / TotalAnswers;
            }
        }
    }
}
