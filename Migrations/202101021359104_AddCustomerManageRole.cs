namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerManageRole : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3bae5a06-5eab-4c4f-bfb9-2f0a20693cab', N'06abad75-27d8-4b43-a168-1007d187ab7b')");
        }
        
        public override void Down()
        {
        }
    }
}
