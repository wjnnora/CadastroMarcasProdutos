namespace Service.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualiza_banco : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "IdBrand", "dbo.Brands");
            AddForeignKey("dbo.Products", "IdBrand", "dbo.Brands", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "IdBrand", "dbo.Brands");
            AddForeignKey("dbo.Products", "IdBrand", "dbo.Brands", "Id");
        }
    }
}
