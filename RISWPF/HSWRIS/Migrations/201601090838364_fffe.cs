namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fffe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
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
                        chushengriqi = c.DateTime(nullable: false),
                        caiyangriqi = c.DateTime(nullable: false),
                        shouyangriqi = c.DateTime(nullable: false),
                        jiancedanriqi = c.DateTime(nullable: false),
                        beizhu = c.DateTime(nullable: false),
                        zhuyuan = c.Boolean(nullable: false),
                        menzhen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet");
        }
    }
}
