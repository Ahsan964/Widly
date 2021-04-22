namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentalsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SongsRentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_Id = c.Int(nullable: false),
                        Song_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Songs", t => t.Song_ID, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Song_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SongsRentals", "Song_ID", "dbo.Songs");
            DropForeignKey("dbo.SongsRentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.SongsRentals", new[] { "Song_ID" });
            DropIndex("dbo.SongsRentals", new[] { "Customer_Id" });
            DropTable("dbo.SongsRentals");
        }
    }
}
