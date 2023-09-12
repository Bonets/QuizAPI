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
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [Required]
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        [Required]
        public int AnswerId { get; set; }
        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }
        [Required]
        public DateTime AnswerDate { get; set; }
        
    }
}
