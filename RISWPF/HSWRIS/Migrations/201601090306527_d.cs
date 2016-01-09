namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.YonghuSets", "zhanghao", c => c.String(nullable: false));
            AlterColumn("dbo.YonghuSets", "mima", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.YonghuSets", "mima", c => c.String());
            AlterColumn("dbo.YonghuSets", "zhanghao", c => c.String());
        }
    }
}
