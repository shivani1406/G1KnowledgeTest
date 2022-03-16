using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using G1KnowledgeTest.Models;
using G1KnowledgeTest.DataAccess.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G1KnowledgeTest.DataAccess.Data.Repository
{
    public class ExamCategoryRepository : Repository<ExamCategory>, IExamCategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public ExamCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.ExamCategory.Select(i => new SelectListItem()
            {
                Text = i.Category,
                Value = i.id.ToString()
            });
        }

        public void Update(ExamCategory examcategory)
        {
            var objFromDb = _db.ExamCategory.FirstOrDefault(s => s.id == examcategory.id);
            objFromDb.Category = examcategory.Category;
            

            _db.SaveChanges();
        }
    }
}
