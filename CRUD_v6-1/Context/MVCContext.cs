using CRUD_v6_1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_v6_1.Context
{
    public class MVCContext: DbContext 
    {
        public MVCContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
