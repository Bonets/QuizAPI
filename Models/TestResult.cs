using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class TestResult
    {
        [Key]
        public int TestResultId {get; set;}
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TestId { get; set; }
        public decimal ResultPercentage { get; set; }
        public DateTime ResultDate { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
    }
}
