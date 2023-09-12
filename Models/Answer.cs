using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    /// <summary>
    /// Contains question's answers
    /// </summary>
    public class Answer
    {
        [Key]
        [Required]
        public int AnswerId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsRightAnswer { get; set; } = false;
        [Required]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }
}
