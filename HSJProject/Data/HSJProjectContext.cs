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

    }
}
