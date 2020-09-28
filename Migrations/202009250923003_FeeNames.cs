namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeeNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "FeeName", c => c.String());
            Sql("UPDATE MembershipTypes SET FeeName = N'Pay as you go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET FeeName = N'Monthly' WHERE DurationInMonths != 0");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "FeeName");
        }
    }
}
