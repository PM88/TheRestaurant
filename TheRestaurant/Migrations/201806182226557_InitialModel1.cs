namespace TheRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        NumberInStock = c.Byte(nullable: false),
                        IngredientUnitId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IngredientUnits", t => t.IngredientUnitId, cascadeDelete: true)
                .Index(t => t.IngredientUnitId);
            
            CreateTable(
                "dbo.IngredientUnits",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        DishTypeId = c.Byte(nullable: false),
                        Description = c.String(maxLength: 255),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.DishTypeId, cascadeDelete: true)
                .Index(t => t.DishTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeIngredients", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipes", "DishTypeId", "dbo.DishTypes");
            DropForeignKey("dbo.RecipeIngredients", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Ingredients", "IngredientUnitId", "dbo.IngredientUnits");
            DropIndex("dbo.Recipes", new[] { "DishTypeId" });
            DropIndex("dbo.RecipeIngredients", new[] { "Recipe_Id" });
            DropIndex("dbo.RecipeIngredients", new[] { "Ingredient_Id" });
            DropIndex("dbo.Ingredients", new[] { "IngredientUnitId" });
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeIngredients");
            DropTable("dbo.IngredientUnits");
            DropTable("dbo.Ingredients");
            DropTable("dbo.DishTypes");
        }
    }
}
