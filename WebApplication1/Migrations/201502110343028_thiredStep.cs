namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thiredStep : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Districts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Thanas", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Thanas", "Name", c => c.String());
            AlterColumn("dbo.Districts", "Name", c => c.String());
        }
    }
}
