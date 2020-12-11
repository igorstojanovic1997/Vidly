namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3bae5a06-5eab-4c4f-bfb9-2f0a20693cab', N'admin@vidly.com', 0, N'AO6p8ZacxwiiHFuW1VOmq6XqbvTL8VLONFyTWU33322YfIv28LdAPpLXxXL9uSbopg==', N'68de8c28-0ccb-4f4d-9728-00763b6a8843', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'42dd5b18-b0e1-42f2-9f87-7076a21df926', N'guest@vidly.com', 0, N'AHXguaOSV9g6xvWeVj12S3C8LdYI6nTfPqsm7uZ6Fl+/aCRJBM6mZ+r4BaSZpho0ww==', N'f8a49d75-0697-4b1b-8bbb-cda13814123c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bfe24a8e-1a64-40a7-80db-7580e6afc403', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3bae5a06-5eab-4c4f-bfb9-2f0a20693cab', N'bfe24a8e-1a64-40a7-80db-7580e6afc403')


");
        }
        
        public override void Down()
        {
        }
    }
}
