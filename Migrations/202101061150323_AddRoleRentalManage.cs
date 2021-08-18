namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleRentalManage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3bae5a06-5eab-4c4f-bfb9-2f0a20693cab', N'26447825-f8be-437f-b321-746c3e602a06')");
        }
        
        public override void Down()
        {
        }
    }
}
