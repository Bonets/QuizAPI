using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    /// <summary>
    /// contains test's questions
    /// </summary>
    public class Question
    {
        [Key]
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

    }
}
