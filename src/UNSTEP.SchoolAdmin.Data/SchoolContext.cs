using Microsoft.EntityFrameworkCore;
using UNSTEP.SchoolAdmin.Data.Models;

namespace UNSTEP.SchoolAdmin.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If database do not exist, then Entity Framework will create one by default based on the connectionstring
            // TODO: Extract this connection string to configuration file
            var connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UNSTEP;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
