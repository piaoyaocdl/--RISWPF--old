namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fefw1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_weidianSet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fenzu = c.String(),
                        leixing = c.String(),
                        weidian = c.String(),
                        yangben_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Zuzhipeixing_linchuanghla_yangbenSet", t => t.yangben_id, cascadeDelete: true)
                .Index(t => t.yangben_id);
            
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofenzu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengweizu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c2");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushaizu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c2");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfeizu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dangezu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dpb1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dangezu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfeizu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c2", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushaizu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c2", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengweizu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofenzu", c => c.Boolean());
            DropForeignKey("dbo.Zuzhipeixing_linchuanghla_weidianSet", "yangben_id", "dbo.Zuzhipeixing_linchuanghla_yangbenSet");
            DropIndex("dbo.Zuzhipeixing_linchuanghla_weidianSet", new[] { "yangben_id" });
            DropTable("dbo.Zuzhipeixing_linchuanghla_weidianSet");
        }
    }
}
