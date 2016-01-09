namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kk : DbMigration
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
                "dbo.YonghuSets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        zhanghao = c.String(nullable: false),
                        mima = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        leixing = c.String(nullable: false),
                        bianhao = c.String(nullable: false, maxLength: 50),
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
                        caiyangriqi = c.DateTime(nullable: false),
                        shouyangriqi = c.DateTime(),
                        jiancedanriqi = c.DateTime(),
                        zhuyuan = c.Boolean(),
                        menzhen = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.bianhao, unique: true, name: "IX_bianhao_weiyi");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "IX_bianhao_weiyi");
            DropTable("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet");
            DropTable("dbo.YonghuSets");
            DropTable("dbo.JichuidSets");
        }
    }
}
