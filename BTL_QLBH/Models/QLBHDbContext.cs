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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
            modelBuilder.Entity<Employee>()
             .Property(e => e.EmployeeId)
             .IsUnicode(false);        
        }

        public System.Data.Entity.DbSet<BTL_QLBH.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<BTL_QLBH.Models.PhieuNhap> PhieuNhaps { get; set; }

        public System.Data.Entity.DbSet<BTL_QLBH.Models.PhieuXuat> PhieuXuats { get; set; }

        public System.Data.Entity.DbSet<BTL_QLBH.Models.NhapKho> NhapKhoes { get; set; }
    }
}