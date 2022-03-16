using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using G1KnowledgeTest.Models;
using G1KnowledgeTest.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace G1KnowledgeTest.DataAccess.Data.Repository
{
   public class Unitofwork : IUnitofwork
    {
        private readonly ApplicationDbContext _db;

        public Unitofwork(ApplicationDbContext db)
        {
            _db = db;
            Category = new ExamCategoryRepository(_db);
            Questions = new QuestionsRepository(_db);
            User = new UserRepository(_db);
        }

       
        
        public IExamCategoryRepository Category { get; private set; }
        public IQuestionsRepository Questions { get; private set; }
        public IUserRepository User { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
