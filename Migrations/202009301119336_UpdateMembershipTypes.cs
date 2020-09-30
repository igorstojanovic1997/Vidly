namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = N'Pay As You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET Name = N'Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET Name = N'Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET Name = N'Annual' WHERE DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
