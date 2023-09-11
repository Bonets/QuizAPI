using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Title { get; set; }
        [Required]
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }
    }
}
