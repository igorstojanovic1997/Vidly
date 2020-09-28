namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateReleaseDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = '6/11/2009' WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '11/12/2009' WHERE Id = 2");
            Sql("UPDATE Movies SET ReleaseDate = '02/12/2009' WHERE Id = 3");
            Sql("UPDATE Movies SET ReleaseDate = '04/05/2009' WHERE Id = 4");
            Sql("UPDATE Movies SET ReleaseDate = '12/08/2009' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
