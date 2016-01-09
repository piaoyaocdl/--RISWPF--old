namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfew : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "chushengriqi", c => c.DateTime());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "shouyangriqi", c => c.DateTime());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "jiancedanriqi", c => c.DateTime());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "beizhu", c => c.DateTime());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "zhuyuan", c => c.Boolean());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "menzhen", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "menzhen", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "zhuyuan", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "beizhu", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "jiancedanriqi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "shouyangriqi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "chushengriqi", c => c.DateTime(nullable: false));
        }
    }
}
