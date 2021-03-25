namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc2eea81-3fc6-4a17-8982-5e663ab54c55', N'admin@gmail.com', 0, N'ALDoe5L3XUSZVud5NmBdvTGx1VVsDyqqTUJ9fur1EKqTlLZDrOe79Ux3FtuJ/RIC9Q==', N'c07f62fc-cfe5-49bc-825a-762b4632ba95', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cfa35e96-10b7-42ed-a8e4-c9696fe86cf2', N'ahsan@gmail.com', 0, N'AL1HmG49aqtUIhNPd6qiT4bVUHJP4LSyjrTuYcQyVa4fT8I1xqOXLq8xES4dmySjjw==', N'399b2bc9-7782-4f98-948f-44c33d00348d', NULL, 0, 0, NULL, 1, 0, N'ahsan@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1fdf267b-a507-4ff6-970d-86ff40829978', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bc2eea81-3fc6-4a17-8982-5e663ab54c55', N'1fdf267b-a507-4ff6-970d-86ff40829978')

");
        }
        
        public override void Down()
        {
        }
    }
}
