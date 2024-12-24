namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2412 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Product", "Alias", c => c.String());
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String());
            AlterColumn("dbo.tb_Product", "Image", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_ProductImage", "IsDefault", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductImage", "IsDefault", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Alias", c => c.String(maxLength: 250));
        }
    }
}
