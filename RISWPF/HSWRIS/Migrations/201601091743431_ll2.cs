namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ll2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "caiyangriqi", c => c.DateTime());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "shouyangriqi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "shouyangriqi", c => c.DateTime());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "caiyangriqi", c => c.DateTime(nullable: false));
        }
    }
}
