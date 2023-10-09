namespace Simrelease.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Public.Dmkh",
                c => new
                    {
                        Ma_kh = c.String(nullable: false, maxLength: 25),
                        Ten_kh = c.String(),
                    })
                .PrimaryKey(t => t.Ma_kh);
            
            CreateTable(
                "Public.Errors",
                c => new
                    {
                        Error_Id = c.String(nullable: false, maxLength: 25),
                        NameError = c.String(),
                    })
                .PrimaryKey(t => t.Error_Id);
            
            CreateTable(
                "Public.Footers",
                c => new
                    {
                        Footer_Id = c.String(nullable: false, maxLength: 25),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Footer_Id);
            
            CreateTable(
                "Public.MenuGroups",
                c => new
                    {
                        MenuGroup_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 50),
                        Menus = c.String(),
                    })
                .PrimaryKey(t => t.MenuGroup_ID);
            
            CreateTable(
                "Public.Menus",
                c => new
                    {
                        Menu_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 50),
                        URL = c.String(nullable: false, maxLength: 256),
                        DisplayOrder = c.Int(),
                        GroupID = c.Int(nullable: false),
                        MenuGroup = c.String(maxLength: 256),
                        Target = c.String(maxLength: 10),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Menu_ID);
            
            CreateTable(
                "Public.OrderDetails",
                c => new
                    {
                        Order_ID = c.String(nullable: false, maxLength: 25),
                        Product_ID = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        Order = c.String(),
                        Product = c.String(),
                    })
                .PrimaryKey(t => new { t.Order_ID, t.Product_ID });
            
            CreateTable(
                "Public.Orders",
                c => new
                    {
                        Orders_Id = c.String(nullable: false, maxLength: 25),
                        CustomeName = c.String(nullable: false, maxLength: 256),
                        CustomerAdress = c.String(nullable: false, maxLength: 256),
                        CustomerEmail = c.String(nullable: false, maxLength: 256),
                        CustomerMobile = c.String(nullable: false, maxLength: 50),
                        CustomerMessage = c.String(nullable: false, maxLength: 256),
                        PaymentMethod = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        PaymentStatus = c.String(),
                        Status = c.Boolean(nullable: false),
                        OrderDetails = c.String(),
                    })
                .PrimaryKey(t => t.Orders_Id);
            
            CreateTable(
                "Public.pages",
                c => new
                    {
                        Page_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Content = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Page_ID);
            
            CreateTable(
                "Public.PostCategories",
                c => new
                    {
                        PostCategory_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                        Post_ID = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PostCategory_ID);
            
            CreateTable(
                "Public.Posts",
                c => new
                    {
                        Post_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(maxLength: 256),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        PostCategory_ID = c.String(),
                        PostTag_ID = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Post_ID);
            
            CreateTable(
                "Public.PostTags",
                c => new
                    {
                        Post_ID = c.String(nullable: false, maxLength: 25),
                        Tag_ID = c.String(nullable: false, maxLength: 25),
                        Post = c.String(),
                        Tag = c.String(),
                    })
                .PrimaryKey(t => new { t.Post_ID, t.Tag_ID });
            
            CreateTable(
                "Public.ProductCategorys",
                c => new
                    {
                        ProductCategory_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                        Products = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductCategory_ID);
            
            CreateTable(
                "Public.Products",
                c => new
                    {
                        Product_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(maxLength: 256),
                        MoreImages = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        ProductCategory = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Product_ID);
            
            CreateTable(
                "Public.ProductTags",
                c => new
                    {
                        Product_ID = c.String(nullable: false, maxLength: 25),
                        Tag_ID = c.String(nullable: false, maxLength: 25),
                        Product = c.String(maxLength: 256),
                        Tag = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.Tag_ID });
            
            CreateTable(
                "Public.Slides",
                c => new
                    {
                        Slide_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        Url = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Slide_ID);
            
            CreateTable(
                "Public.SupportOnlines",
                c => new
                    {
                        SupportOnline_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 50),
                        Department = c.String(maxLength: 50),
                        Skype = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Yahoo = c.String(maxLength: 50),
                        Facebook = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(),
                    })
                .PrimaryKey(t => t.SupportOnline_ID);
            
            CreateTable(
                "Public.SystemConfigs",
                c => new
                    {
                        SystemConfig_ID = c.String(nullable: false, maxLength: 25),
                        Code = c.String(nullable: false, maxLength: 50),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.SystemConfig_ID);
            
            CreateTable(
                "Public.Tags",
                c => new
                    {
                        Tag_ID = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 256),
                        Type = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Tag_ID);
            
        }
        
        public override void Down()
        {
            DropTable("Public.Tags");
            DropTable("Public.SystemConfigs");
            DropTable("Public.SupportOnlines");
            DropTable("Public.Slides");
            DropTable("Public.ProductTags");
            DropTable("Public.Products");
            DropTable("Public.ProductCategorys");
            DropTable("Public.PostTags");
            DropTable("Public.Posts");
            DropTable("Public.PostCategories");
            DropTable("Public.pages");
            DropTable("Public.Orders");
            DropTable("Public.OrderDetails");
            DropTable("Public.Menus");
            DropTable("Public.MenuGroups");
            DropTable("Public.Footers");
            DropTable("Public.Errors");
            DropTable("Public.Dmkh");
        }
    }
}
