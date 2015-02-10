namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateMedicine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicineOrders",
                c => new
                    {
                        MedicineOrderID = c.Int(nullable: false, identity: true),
                        MedicineName = c.String(),
                        Quantity = c.String(),
                    })
                .PrimaryKey(t => t.MedicineOrderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedicineOrders");
        }
    }
}
