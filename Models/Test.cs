using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; } = string.Empty;
    }
}
