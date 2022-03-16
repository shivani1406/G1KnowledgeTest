using System;
using System.Collections.Generic;
using System.Text;

namespace G1KnowledgeTest.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<ExamCategory> CategoryList { get; set; }
        public IEnumerable<Questions> QuestionsList { get; set; }
    }
}
