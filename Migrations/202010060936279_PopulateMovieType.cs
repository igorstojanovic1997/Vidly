namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieTypes(Id, Name) VALUES(1, N'Action')");
            Sql("INSERT INTO MovieTypes(Id, Name) VALUES(2, N'Comedy')");
            Sql("INSERT INTO MovieTypes(Id, Name) VALUES(3, N'Sci-fi')");
            Sql("INSERT INTO MovieTypes(Id, Name) VALUES(4, N'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
