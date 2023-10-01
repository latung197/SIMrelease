namespace SIMrelease.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SIM1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategorys");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Posts", new[] { "CategoryID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.ProductTags", new[] { "TagID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ProductTags", "TagID");
            CreateIndex("dbo.ProductTags", "ProductID");
            CreateIndex("dbo.PostTags", "TagID");
            CreateIndex("dbo.PostTags", "PostID");
            CreateIndex("dbo.Posts", "CategoryID");
            CreateIndex("dbo.Products", "CategoryID");
            CreateIndex("dbo.OrderDetails", "ProductID");
            CreateIndex("dbo.OrderDetails", "OrderID");
            CreateIndex("dbo.Menus", "GroupID");
            AddForeignKey("dbo.ProductTags", "TagID", "dbo.Tags", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ProductTags", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            AddForeignKey("dbo.PostTags", "TagID", "dbo.Tags", "ID", cascadeDelete: true);
            AddForeignKey("dbo.PostTags", "PostID", "dbo.Posts", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategorys", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups", "ID", cascadeDelete: true);
        }
    }
}
