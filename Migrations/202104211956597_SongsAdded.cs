namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SongsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Album = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
        }
    }
}
