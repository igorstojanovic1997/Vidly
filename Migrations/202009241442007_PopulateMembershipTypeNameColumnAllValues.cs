namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNameColumnAllValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = N'10% Discount' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET Name = N'15% Discount' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET Name = N'20% Discount' WHERE DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
