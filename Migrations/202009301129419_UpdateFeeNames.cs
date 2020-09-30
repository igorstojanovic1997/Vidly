namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFeeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET FeeName = N'No Discount' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET FeeName = N'10% Discount' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET FeeName = N'15% Discount' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET FeeName = N'20% Discount' WHERE DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
