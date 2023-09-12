using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    /// <summary>
    /// contains every answer of every question of every test made by the user
    /// </summary>
    public class UserTestQuestionAnswer
    {
        [Key]
        public int UserTestQuestionAnswerId { get; set; }

        [Required]
        public int TestResultId { get; set; }

        [ForeignKey("TestResultId")]
        public virtual TestResult TestResult { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [Required]
        public int AnswerId { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }

        [Required]
        public DateTime AnswerDate { get; set; }

    }
}
