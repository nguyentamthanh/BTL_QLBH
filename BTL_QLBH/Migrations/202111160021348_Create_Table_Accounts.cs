namespace BTL_QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Accounts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128, unicode: false),
                        EmployeeName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.nhaps",
                c => new
                    {
                        STT = c.String(nullable: false, maxLength: 10),
                        MaPhieuNhap = c.String(maxLength: 50),
                        MaHangHoa = c.String(maxLength: 10),
                        SoLuong = c.Int(),
                        NgayNhap = c.DateTime(storeType: "date"),
                        MaNCCS = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.phieunhap",
                c => new
                    {
                        MaPhieuNhap = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaNCC = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.phieuxuat",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 10),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        Address = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.phieuxuat");
            DropTable("dbo.phieunhap");
            DropTable("dbo.nhaps");
            DropTable("dbo.Employee");
            DropTable("dbo.Accounts");
        }
    }
}
