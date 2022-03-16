using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using G1KnowledgeTest.Models;

namespace G1KnowledgeTest.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void LockUser(string userId);

        void UnLockUser(string userId);
    }
}