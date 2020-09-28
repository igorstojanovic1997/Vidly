namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDateAdded : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded = '9/25/2020' WHERE Id = 1");
            Sql("UPDATE Movies SET DateAdded = '9/25/2020' WHERE Id = 2");
            Sql("UPDATE Movies SET DateAdded = '9/25/2020' WHERE Id = 3");
            Sql("UPDATE Movies SET DateAdded = '9/25/2020' WHERE Id = 4");
            Sql("UPDATE Movies SET DateAdded = '9/25/2020' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
