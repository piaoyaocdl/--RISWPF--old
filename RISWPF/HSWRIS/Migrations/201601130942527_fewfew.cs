namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfew : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "xingming", c => c.String(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "leixing", c => c.String(nullable: false));
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenbianhao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenbianhao", c => c.String());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "leixing", c => c.String());
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "xingming", c => c.String());
        }
    }
}
