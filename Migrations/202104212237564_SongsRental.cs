namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SongsRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Song_ID", c => c.Int());
            CreateIndex("dbo.Rentals", "Song_ID");
            AddForeignKey("dbo.Rentals", "Song_ID", "dbo.Songs", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Song_ID", "dbo.Songs");
            DropIndex("dbo.Rentals", new[] { "Song_ID" });
            DropColumn("dbo.Rentals", "Song_ID");
        }
    }
}
