using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models
{
    /// <summary>
    /// contains test definition
    /// </summary>
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
