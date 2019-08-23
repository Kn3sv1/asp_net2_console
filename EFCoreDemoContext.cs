using Microsoft.EntityFrameworkCore;

namespace asp_net2_console
{
    public class EFCoreDemoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(@"Server=.\;Data Source=(LocalDb)\v11.0;Initial Catalog=EFCoreDemo2;Integrated Security=SSPI;");
        }
    }
}