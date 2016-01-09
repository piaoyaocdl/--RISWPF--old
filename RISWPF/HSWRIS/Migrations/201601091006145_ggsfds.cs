namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ggsfds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "leixing", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "leixing");
        }
    }
}
