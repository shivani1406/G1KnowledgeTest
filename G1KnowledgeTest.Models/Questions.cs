using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace G1KnowledgeTest.Models
{
   public class Questions
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name ="Ques")]
        public string Question { get; set; }

        [Required]
        [Display(Name ="Option1")]
        public string Option1 { get; set; }

        [Required]
        [Display(Name = "Option2")]
        public string Option2 { get; set; }

        [Required]
        [Display(Name = "Option3")]
        public string Option3 { get; set; }

        [Required]
        [Display(Name = "Option4")]
        public string Option4 { get; set; }

        [Required]
        [Display(Name ="Answer")]
        public int Answer { get; set; }

        public byte[] Picture { get; set; }

        public string Remark { get; set; }

        [Required]
        public int CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        public ExamCategory Category { get; set; }

    }
}
