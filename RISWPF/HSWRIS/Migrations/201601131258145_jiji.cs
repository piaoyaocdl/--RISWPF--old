namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jiji : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JueseSets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        jueseming = c.String(nullable: false),
                        shuoming = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.YonghuSetJueseSets",
                c => new
                    {
                        YonghuSet_id = c.Int(nullable: false),
                        JueseSet_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.YonghuSet_id, t.JueseSet_id })
                .ForeignKey("dbo.YonghuSets", t => t.YonghuSet_id, cascadeDelete: true)
                .ForeignKey("dbo.JueseSets", t => t.JueseSet_id, cascadeDelete: true)
                .Index(t => t.YonghuSet_id)
                .Index(t => t.JueseSet_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YonghuSetJueseSets", "JueseSet_id", "dbo.JueseSets");
            DropForeignKey("dbo.YonghuSetJueseSets", "YonghuSet_id", "dbo.YonghuSets");
            DropIndex("dbo.YonghuSetJueseSets", new[] { "JueseSet_id" });
            DropIndex("dbo.YonghuSetJueseSets", new[] { "YonghuSet_id" });
            DropTable("dbo.YonghuSetJueseSets");
            DropTable("dbo.JueseSets");
        }
    }
}
