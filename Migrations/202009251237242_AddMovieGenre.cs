namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre = 'Comedy' WHERE Id = 1");
            Sql("UPDATE Movies SET Genre = 'Action' WHERE Id = 2");
            Sql("UPDATE Movies SET Genre = 'Action' WHERE Id = 3");
            Sql("UPDATE Movies SET Genre = 'Family' WHERE Id = 4");
            Sql("UPDATE Movies SET Genre = 'Romance' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
