using HSJProject.DataModels;
using Microsoft.EntityFrameworkCore;

namespace HSJProject.Data
{
    public class HSJProjectContext : DbContext
    {

        public HSJProjectContext(DbContextOptions<HSJProjectContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contact { get;set;} = default!;
        public DbSet<Product> Products { get;set;} = default!;
        public DbSet<Blog> Blog { get;set;} = default!;

    }
}
