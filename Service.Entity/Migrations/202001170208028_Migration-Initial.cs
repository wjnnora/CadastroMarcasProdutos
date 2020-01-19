namespace Service.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdBrand = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Brands", t => t.IdBrand)
                .Index(t => t.IdBrand);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "IdBrand", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "IdBrand" });
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
