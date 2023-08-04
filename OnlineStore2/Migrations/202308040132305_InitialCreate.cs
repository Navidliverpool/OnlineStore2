namespace TestUsersCopy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        MotoCategory = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Motorcycles",
                c => new
                    {
                        MotorcycleId = c.Int(nullable: false, identity: true),
                        Model = c.String(nullable: false, maxLength: 20),
                        Price = c.Double(nullable: false),
                        Image = c.Binary(),
                        BrandId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MotorcycleId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        Count = c.Int(),
                        DateCreated = c.DateTime(),
                        MotorcycleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId)
                .ForeignKey("dbo.Motorcycles", t => t.MotorcycleId, cascadeDelete: true)
                .Index(t => t.MotorcycleId);
            
            CreateTable(
                "dbo.Dealers",
                c => new
                    {
                        DealerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DealerId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        MotorcycleId = c.Int(nullable: false),
                        Quantity = c.Int(),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Motorcycles", t => t.MotorcycleId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.MotorcycleId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 160),
                        LastName = c.String(nullable: false, maxLength: 160),
                        City = c.String(nullable: false, maxLength: 40),
                        State = c.String(nullable: false, maxLength: 40),
                        PostalCode = c.String(nullable: false, maxLength: 10),
                        Country = c.String(nullable: false, maxLength: 40),
                        Phone = c.String(nullable: false, maxLength: 24),
                        Email = c.String(nullable: false),
                        Total = c.Decimal(precision: 18, scale: 2),
                        OrderDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.MotorcycleDealers",
                c => new
                    {
                        MotorcycleId = c.Int(nullable: false),
                        DealerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MotorcycleId, t.DealerId })
                .ForeignKey("dbo.Motorcycles", t => t.MotorcycleId, cascadeDelete: true)
                .ForeignKey("dbo.Dealers", t => t.DealerId, cascadeDelete: true)
                .Index(t => t.MotorcycleId)
                .Index(t => t.DealerId);
            
            CreateTable(
                "dbo.BrandCategories",
                c => new
                    {
                        BrandId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BrandId, t.CategoryId })
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.BrandDealers",
                c => new
                    {
                        BrandId = c.Int(nullable: false),
                        DealerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BrandId, t.DealerId })
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Dealers", t => t.DealerId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.DealerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BrandDealers", "DealerId", "dbo.Dealers");
            DropForeignKey("dbo.BrandDealers", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.BrandCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BrandCategories", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "MotorcycleId", "dbo.Motorcycles");
            DropForeignKey("dbo.MotorcycleDealers", "DealerId", "dbo.Dealers");
            DropForeignKey("dbo.MotorcycleDealers", "MotorcycleId", "dbo.Motorcycles");
            DropForeignKey("dbo.Motorcycles", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Carts", "MotorcycleId", "dbo.Motorcycles");
            DropForeignKey("dbo.Motorcycles", "BrandId", "dbo.Brands");
            DropIndex("dbo.BrandDealers", new[] { "DealerId" });
            DropIndex("dbo.BrandDealers", new[] { "BrandId" });
            DropIndex("dbo.BrandCategories", new[] { "CategoryId" });
            DropIndex("dbo.BrandCategories", new[] { "BrandId" });
            DropIndex("dbo.MotorcycleDealers", new[] { "DealerId" });
            DropIndex("dbo.MotorcycleDealers", new[] { "MotorcycleId" });
            DropIndex("dbo.OrderDetails", new[] { "MotorcycleId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Carts", new[] { "MotorcycleId" });
            DropIndex("dbo.Motorcycles", new[] { "CategoryId" });
            DropIndex("dbo.Motorcycles", new[] { "BrandId" });
            DropTable("dbo.BrandDealers");
            DropTable("dbo.BrandCategories");
            DropTable("dbo.MotorcycleDealers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Dealers");
            DropTable("dbo.Carts");
            DropTable("dbo.Motorcycles");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
        }
    }
}
