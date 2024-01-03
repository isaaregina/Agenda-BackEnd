using Crud_Agenda.Model;
using Microsoft.EntityFrameworkCore;

namespace Crud_Agenda.Data
{
    public class ContactContext : DbContext
    {
        public DbSet<ContactModel> Contacts { get; set; };

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=contacts;" +
              "User Id=postgres;" +
              "Password=root2023;");
    }
}
