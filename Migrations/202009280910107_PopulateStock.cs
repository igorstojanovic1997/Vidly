namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStock : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Stock = 5 WHERE Id = 1");
            Sql("UPDATE Movies SET Stock = 3 WHERE Id = 2");
            Sql("UPDATE Movies SET Stock = 8 WHERE Id = 3");
            Sql("UPDATE Movies SET Stock = 15 WHERE Id = 4");
            Sql("UPDATE Movies SET Stock = 1 WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
