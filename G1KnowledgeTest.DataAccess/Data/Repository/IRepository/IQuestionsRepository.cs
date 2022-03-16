using G1KnowledgeTest.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace G1KnowledgeTest.DataAccess.Data.Repository.IRepository
{
   public interface IQuestionsRepository : IRepository<Questions>
    {
        public interface IQuestionsRepository : IRepository<Questions>
        {

            void Update(Questions questions);
        }
    }
   
}
