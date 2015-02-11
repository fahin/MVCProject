namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondStep : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Centres", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Centres", "Name", c => c.String());
        }
    }
}
