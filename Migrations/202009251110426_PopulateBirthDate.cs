namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '12/18/1997' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '08/11/1996' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
