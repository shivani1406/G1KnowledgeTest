using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace G1KnowledgeTest.Models.ViewModel
{
   public class QuestionVM
    {
        public Questions Questions { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        //public IEnumerable<SelectListItem> FrequencyList { get; set; }
    }
}
