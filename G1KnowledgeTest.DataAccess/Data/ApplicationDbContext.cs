using System;
using System.Collections.Generic;
using System.Text;
using G1KnowledgeTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace G1KnowledgeTest.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ExamCategory> ExamCategory { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
