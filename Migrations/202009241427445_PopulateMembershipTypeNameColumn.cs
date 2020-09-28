namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNameColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = N'No discount' WHERE DurationInMonths = 0");
        }
        
        public override void Down()
        {
        }
    }
}
