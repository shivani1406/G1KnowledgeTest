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
    public class QuestionsRepository : Repository<Questions>, IQuestionsRepository
    {
        private readonly ApplicationDbContext _db;

        public QuestionsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Questions questions)
        {
            var objFromDb = _db.Questions.FirstOrDefault(s => s.id == questions.id);
            objFromDb.Question = questions.Question;
            objFromDb.Option1 = questions.Option1;
            objFromDb.Option2 = questions.Option2;
            objFromDb.Option3 = questions.Option3;
            objFromDb.Option4 = questions.Option4;
            objFromDb.Answer = questions.Answer;
            objFromDb.Picture = questions.Picture;
            objFromDb.Remark = questions.Remark;
            objFromDb.CategoryId = questions.CategoryId;

            _db.SaveChanges();
        }
    }
}
