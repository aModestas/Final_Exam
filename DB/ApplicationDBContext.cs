using Final_Exam.Entities;
using Microsoft.EntityFrameworkCore;

namespace Final_Exam.DB
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
