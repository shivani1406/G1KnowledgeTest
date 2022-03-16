using System;
using System.Collections.Generic;
using System.Text;

namespace G1KnowledgeTest.DataAccess.Data.Repository.IRepository
{
   public interface IUnitofwork
    {
        IExamCategoryRepository Category { get; }

        IQuestionsRepository Questions { get; }
        IUserRepository User { get; }
        void Save();

        


    }
}

