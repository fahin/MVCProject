namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreaorders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MedicineOrders", "Medicine", c => c.String());
            AddColumn("dbo.MedicineOrders", "Centre", c => c.String());
            DropColumn("dbo.MedicineOrders", "MedicineName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MedicineOrders", "MedicineName", c => c.String());
            DropColumn("dbo.MedicineOrders", "Centre");
            DropColumn("dbo.MedicineOrders", "Medicine");
        }
    }
}
