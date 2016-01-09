namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ll1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "IX_bianhao_weiyi");
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "bianhao", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "bianhao", unique: true, name: "IX_bianhao_weiyi");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "IX_bianhao_weiyi");
            AlterColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "bianhao", c => c.String(maxLength: 50));
            CreateIndex("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "bianhao", unique: true, name: "IX_bianhao_weiyi");
        }
    }
}
