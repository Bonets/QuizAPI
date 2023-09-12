﻿using System.ComponentModel.DataAnnotations;

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
        public string TestName { get; set; } = string.Empty;
        public virtual ICollection<Question> Questions { get; set; }
    }
}