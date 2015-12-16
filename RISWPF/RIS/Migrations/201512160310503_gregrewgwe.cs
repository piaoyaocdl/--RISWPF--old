namespace RIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gregrewgwe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WenjianSets",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        wenjian = c.Binary(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.WenjianshuomingSets",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        wenjianming = c.String(),
                        daxiao = c.String(),
                        wenjianid = c.Long(nullable: false),
                        Zuzhipeixing_linchuanghla_shenqingdanSet_id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.WenjianSets", t => t.wenjianid, cascadeDelete: true)
                .ForeignKey("dbo.Zuzhipeixing_linchuanghla_shenqingdanSet", t => t.Zuzhipeixing_linchuanghla_shenqingdanSet_id)
                .Index(t => t.wenjianid)
                .Index(t => t.Zuzhipeixing_linchuanghla_shenqingdanSet_id);
            
            CreateTable(
                "dbo.YonghuSets",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        zhanghao = c.String(nullable: false),
                        mima = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_shenqingdanSet",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        shenqingdanbianhao = c.String(),
                        huanzhexingming = c.String(),
                        xingbie = c.String(),
                        chushengriqi = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_yangbenSet",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        yangbenbianhao = c.String(),
                        xingming = c.String(),
                        xingbie = c.String(),
                        gonghuanguanxi = c.String(),
                        shenqingdanid = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Zuzhipeixing_linchuanghla_shenqingdanSet", t => t.shenqingdanid, cascadeDelete: true)
                .Index(t => t.shenqingdanid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shenqingdanid", "dbo.Zuzhipeixing_linchuanghla_shenqingdanSet");
            DropForeignKey("dbo.WenjianshuomingSets", "Zuzhipeixing_linchuanghla_shenqingdanSet_id", "dbo.Zuzhipeixing_linchuanghla_shenqingdanSet");
            DropForeignKey("dbo.WenjianshuomingSets", "wenjianid", "dbo.WenjianSets");
            DropIndex("dbo.Zuzhipeixing_linchuanghla_yangbenSet", new[] { "shenqingdanid" });
            DropIndex("dbo.WenjianshuomingSets", new[] { "Zuzhipeixing_linchuanghla_shenqingdanSet_id" });
            DropIndex("dbo.WenjianshuomingSets", new[] { "wenjianid" });
            DropTable("dbo.Zuzhipeixing_linchuanghla_yangbenSet");
            DropTable("dbo.Zuzhipeixing_linchuanghla_shenqingdanSet");
            DropTable("dbo.YonghuSets");
            DropTable("dbo.WenjianshuomingSets");
            DropTable("dbo.WenjianSets");
        }
    }
}
