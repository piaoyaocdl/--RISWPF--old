namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfw : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JichuidSets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        biaoming = c.String(nullable: false),
                        lieming = c.String(nullable: false),
                        zifenlei = c.String(),
                        gengxinpinlv = c.String(nullable: false),
                        gengxinshijian = c.DateTime(nullable: false),
                        jichuid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
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
                "dbo.YonghuSets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        zhanghao = c.String(nullable: false, maxLength: 50),
                        mima = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.zhanghao, unique: true, name: "IX_zhanghao_weiyi_yueshu");
            
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        bianhao = c.String(),
                        huanzhexingming = c.String(nullable: false),
                        xingbie = c.String(),
                        shenfenzhenghao = c.String(),
                        linchuangzhenduan = c.String(),
                        chuanghao = c.String(),
                        shenqingyiyuan = c.String(),
                        shenqingyisheng = c.String(),
                        zhuyuanhao = c.String(),
                        baogaofasongfangshi = c.String(),
                        lianxidianhua = c.String(),
                        fax = c.String(),
                        email = c.String(),
                        youbian = c.String(),
                        tongxundizhi = c.String(),
                        shouyangzhe = c.String(),
                        beizhu = c.String(),
                        chushengriqi = c.DateTime(),
                        caiyangriqi = c.DateTime(),
                        shouyangriqi = c.DateTime(nullable: false),
                        jiancedanriqi = c.DateTime(),
                        zhuyuan = c.Boolean(),
                        menzhen = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_yangbenSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        yuanshibianhao = c.String(),
                        xingming = c.String(nullable: false),
                        xingbie = c.String(),
                        chushengriqi = c.DateTime(),
                        leixing = c.String(nullable: false),
                        yangbenbianhao = c.String(nullable: false),
                        huanzhebenren = c.Boolean(),
                        gonghuanguanxi = c.String(),
                        songjiandanwei = c.String(),
                        yangbenleixing = c.String(),
                        yangguanshu = c.Int(),
                        yangbenhege = c.Boolean(),
                        caiyangriqi = c.DateTime(),
                        shouyangriqi = c.DateTime(),
                        fufeiriqi = c.DateTime(),
                        shouyangzhe = c.String(),
                        jianceriqi = c.DateTime(),
                        beizhu = c.String(),
                        shenqingdan_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", t => t.shenqingdan_id, cascadeDelete: true)
                .Index(t => t.shenqingdan_id);
            
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_weidianSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fenzu = c.String(),
                        leixing = c.String(),
                        weidian = c.String(),
                        beizhu = c.String(),
                        yangben_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Zuzhipeixing_linchuanghla_yangbenSet", t => t.yangben_id, cascadeDelete: true)
                .Index(t => t.yangben_id);
            
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
            DropForeignKey("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shenqingdan_id", "dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet");
            DropForeignKey("dbo.Zuzhipeixing_linchuanghla_weidianSet", "yangben_id", "dbo.Zuzhipeixing_linchuanghla_yangbenSet");
            DropForeignKey("dbo.YonghuSetJueseSets", "JueseSet_id", "dbo.JueseSets");
            DropForeignKey("dbo.YonghuSetJueseSets", "YonghuSet_id", "dbo.YonghuSets");
            DropIndex("dbo.YonghuSetJueseSets", new[] { "JueseSet_id" });
            DropIndex("dbo.YonghuSetJueseSets", new[] { "YonghuSet_id" });
            DropIndex("dbo.Zuzhipeixing_linchuanghla_weidianSet", new[] { "yangben_id" });
            DropIndex("dbo.Zuzhipeixing_linchuanghla_yangbenSet", new[] { "shenqingdan_id" });
            DropIndex("dbo.YonghuSets", "IX_zhanghao_weiyi_yueshu");
            DropTable("dbo.YonghuSetJueseSets");
            DropTable("dbo.Zuzhipeixing_linchuanghla_weidianSet");
            DropTable("dbo.Zuzhipeixing_linchuanghla_yangbenSet");
            DropTable("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet");
            DropTable("dbo.YonghuSets");
            DropTable("dbo.JueseSets");
            DropTable("dbo.JichuidSets");
        }
    }
}
