namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoovePhone : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.Int(nullable: false));
        }
    }
}
