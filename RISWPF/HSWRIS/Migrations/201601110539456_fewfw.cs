namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfw : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "huanzhebenren", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangriqi", c => c.DateTime());
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "huanzhebeiren");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangriq");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangriq", c => c.DateTime());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "huanzhebeiren", c => c.Boolean());
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangriqi");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "huanzhebenren");
        }
    }
}
