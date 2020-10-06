namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieAddMovieTypeId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "MovieType_Id", c => c.Byte());
            CreateIndex("dbo.Movies", "MovieType_Id");
            AddForeignKey("dbo.Movies", "MovieType_Id", "dbo.MovieTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieType_Id", "dbo.MovieTypes");
            DropIndex("dbo.Movies", new[] { "MovieType_Id" });
            DropColumn("dbo.Movies", "MovieType_Id");
            DropColumn("dbo.Movies", "MovieTypeId");
        }
    }
}
