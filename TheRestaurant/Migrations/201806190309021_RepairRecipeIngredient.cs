namespace TheRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepairRecipeIngredient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RecipeIngredients", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.RecipeIngredients", "Ingredient_Id", "dbo.Ingredients");
            DropIndex("dbo.RecipeIngredients", new[] { "Recipe_Id" });
            DropIndex("dbo.RecipeIngredients", new[] { "Ingredient_Id" });
            DropTable("dbo.RecipeIngredients");

            CreateTable(
                "dbo.RecipeIngredients",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NumberOfIngredients = c.Byte(nullable: false),
                    Ingredient_Id = c.Int(nullable: false),
                    Recipe_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Recipe_Id);
        }
        
        public override void Down()
        {

        }
    }
}
