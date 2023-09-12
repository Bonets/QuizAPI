using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    /// <summary>
    /// contains tests result of the user with date
    /// </summary>
    public class TestResult
    {
        [Key] 
        public int TestResultId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public decimal ResultPercentage { get; set; }
        [Required]
        public DateTime ResultDate { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
    }
}
