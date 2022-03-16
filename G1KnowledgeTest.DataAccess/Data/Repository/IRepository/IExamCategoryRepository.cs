using G1KnowledgeTest.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace G1KnowledgeTest.DataAccess.Data.Repository.IRepository
{
   public interface IExamCategoryRepository : IRepository<ExamCategory>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();
        void Update(ExamCategory examcategory);
    }
   
}
