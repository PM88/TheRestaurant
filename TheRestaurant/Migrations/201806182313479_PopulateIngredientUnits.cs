namespace TheRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateIngredientUnits : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO IngredientUnits (Id, Name) VALUES (1, 'liter')");
            Sql("INSERT INTO IngredientUnits (Id, Name) VALUES (2, 'gramme')");
            Sql("INSERT INTO IngredientUnits (Id, Name) VALUES (3, 'piece')");
        }
        
        public override void Down()
        {
        }
    }
}
