namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name)VALUES('Comedy')");
            Sql("INSERT INTO Genres(Name)VALUES('Action')");
            Sql("INSERT INTO Genres(Name)VALUES('Thriller')");
            Sql("INSERT INTO Genres(Name)VALUES('Mystery')");
            Sql("INSERT INTO Genres(Name)VALUES('Sci-Fi')");
            Sql("INSERT INTO Genres(Name)VALUES('Drama')");
            Sql("INSERT INTO Genres(Name)VALUES('Documentary')");
            Sql("INSERT INTO Genres(Name)VALUES('Biography')");
            Sql("INSERT INTO Genres(Name)VALUES('Crime')");
        }
        
        public override void Down()
        {
        }
    }
}
