namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfewq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "beizhu", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "beizhu", c => c.DateTime());
        }
    }
}
