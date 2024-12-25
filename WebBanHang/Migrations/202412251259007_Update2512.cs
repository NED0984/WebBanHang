namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2512 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.tb_Product", "IsActice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "IsActice", c => c.Boolean(nullable: false));
            DropColumn("dbo.tb_Product", "IsActive");
        }
    }
}
