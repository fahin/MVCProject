namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstStep : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Centres",
                c => new
                    {
                        CentreID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ThanaID = c.Int(nullable: false),
                        DistrictID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CentreID)
                .ForeignKey("dbo.Districts", t => t.DistrictID, cascadeDelete: true)
                .ForeignKey("dbo.Thanas", t => t.ThanaID, cascadeDelete: true)
                .Index(t => t.ThanaID)
                .Index(t => t.DistrictID);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DistrictID);
            
            CreateTable(
                "dbo.Thanas",
                c => new
                    {
                        ThanaID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DistrictID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThanaID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Degree = c.String(),
                        Specialization = c.String(),
                    })
                .PrimaryKey(t => t.DoctorID);
            
            CreateTable(
                "dbo.MedicineOrders",
                c => new
                    {
                        MedicineOrderID = c.Int(nullable: false, identity: true),
                        Medicine = c.String(),
                        Quantity = c.String(),
                        Centre = c.String(),
                    })
                .PrimaryKey(t => t.MedicineOrderID);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        MedicineID = c.Int(nullable: false, identity: true),
                        MedidineName = c.String(),
                        Power = c.String(),
                    })
                .PrimaryKey(t => t.MedicineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Centres", "ThanaID", "dbo.Thanas");
            DropForeignKey("dbo.Centres", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Centres", new[] { "DistrictID" });
            DropIndex("dbo.Centres", new[] { "ThanaID" });
            DropTable("dbo.Medicines");
            DropTable("dbo.MedicineOrders");
            DropTable("dbo.Doctors");
            DropTable("dbo.Thanas");
            DropTable("dbo.Districts");
            DropTable("dbo.Centres");
        }
    }
}
