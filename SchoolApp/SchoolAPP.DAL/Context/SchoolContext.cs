

using Microsoft.EntityFrameworkCore;
using SchoolAPP.DAL.Entities;

namespace SchoolAPP.DAL.Context
{
    public class SchoolContext : DbContext
    {
        #region"Constructor"
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        #endregion
        #region"DbSets"
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        #endregion
    }
}
