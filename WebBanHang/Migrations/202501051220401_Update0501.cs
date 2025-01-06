namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update0501 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_New", "CategoryId", "dbo.tb_Category");
            DropForeignKey("dbo.tb_Post", "CategoryId", "dbo.tb_Category");
            DropIndex("dbo.tb_New", new[] { "CategoryId" });
            DropIndex("dbo.tb_Post", new[] { "CategoryId" });
            DropTable("dbo.tb_New");
            DropTable("dbo.tb_Post");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tb_Post",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_New",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.tb_Post", "CategoryId");
            CreateIndex("dbo.tb_New", "CategoryId");
            AddForeignKey("dbo.tb_Post", "CategoryId", "dbo.tb_Category", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tb_New", "CategoryId", "dbo.tb_Category", "Id", cascadeDelete: true);
        }
    }
}
