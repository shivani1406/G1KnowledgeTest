using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G1KnowledgeTest.Models
{
   public class ExamCategory
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display (Name ="Exam Category")]
        public string Category { get; set; }
    }
}
