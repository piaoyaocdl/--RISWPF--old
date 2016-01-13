namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jiji2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.YonghuSets", "zhanghao", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.YonghuSets", "zhanghao", unique: true, name: "IX_zhanghao_weiyi_yueshu");
        }
        
        public override void Down()
        {
            DropIndex("dbo.YonghuSets", "IX_zhanghao_weiyi_yueshu");
            AlterColumn("dbo.YonghuSets", "zhanghao", c => c.String(nullable: false));
        }
    }
}
