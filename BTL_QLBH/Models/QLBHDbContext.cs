using System.Data.Entity;

namespace BTL_QLBH.Models
{
    public partial class QLBHDbContext : DbContext

    {
        public QLBHDbContext() : base("name=QLBHDbContext")
        {
        }
   
        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
        }
    }
}