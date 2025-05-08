using Microsoft.EntityFrameworkCore;

using ProjectSDA.Models;

namespace ProjectSDA.Data
{
    public class StudentRepo : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentRepo(DbContextOptions<StudentRepo> options) : base(options)
        {
        }








    }
}
