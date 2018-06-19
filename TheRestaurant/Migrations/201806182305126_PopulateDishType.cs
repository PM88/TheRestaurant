namespace TheRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDishType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Dishtypes (Id, Name) VALUES (1, 'Sweet')");
            Sql("INSERT INTO Dishtypes (Id, Name) VALUES (2, 'Sour')");
            Sql("INSERT INTO Dishtypes (Id, Name) VALUES (3, 'Spicy')");
            Sql("INSERT INTO Dishtypes (Id, Name) VALUES (4, 'Sweet and sour')");
            Sql("INSERT INTO Dishtypes (Id, Name) VALUES (5, 'Unsweetened ')");
        }
        
        public override void Down()
        {
        }
    }
}
