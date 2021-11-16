using System.Data.Entity;

namespace BTL_QLBH.Models
{
    public partial class QLBHDbContext : DbContext

    {
        public QLBHDbContext() : base("name=QLBHDbContext")
        {
        }
   
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }

        public virtual DbSet<NhapKho> NhapKhoes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
            modelBuilder.Entity<Employee>()
             .Property(e => e.EmployeeId)
             .IsUnicode(false);        
        }
    }
}