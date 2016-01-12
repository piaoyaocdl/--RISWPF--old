namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_weidianSet", "beizhu", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zuzhipeixing_linchuanghla_weidianSet", "beizhu");
        }
    }
}
