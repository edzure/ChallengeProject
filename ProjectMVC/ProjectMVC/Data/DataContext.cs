using ProjectMVC.Models;
using System.Data.Entity;

namespace ProjectMVC
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Porjects { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
    }
}