using CrudAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Data
{
    public class ContactsAPIdbContext : DbContext
    {
        public ContactsAPIdbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
