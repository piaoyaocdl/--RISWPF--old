namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jiji : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Zuzhipeixing_linchuanghla_weidianSet", "jiancefou");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_weidianSet", "jiancefou", c => c.Boolean(nullable: false));
        }
    }
}
