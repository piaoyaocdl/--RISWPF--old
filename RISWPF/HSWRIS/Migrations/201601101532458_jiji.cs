namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jiji : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_yangbenSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ceshi = c.String(),
                        shenqingdan_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", t => t.shenqingdan_id, cascadeDelete: true)
                .Index(t => t.shenqingdan_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shenqingdan_id", "dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet");
            DropIndex("dbo.Zuzhipeixing_linchuanghla_yangbenSet", new[] { "shenqingdan_id" });
            DropTable("dbo.Zuzhipeixing_linchuanghla_yangbenSet");
        }
    }
}
