namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofenzu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengweizu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c2", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushaizu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c2", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfeizu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dangezu", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dpb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_a", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_b", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_drb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_c", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dqb1", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dpb1", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dange_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dangezu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfei_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "mianfeizu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c2");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ngs_c1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushai_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushaizu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c2");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ngs_c1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengwei_ssop_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "dengweizu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dpb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_dqb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_c");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_drb1");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_b");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofen_sbt_a");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gaofenzu");
        }
    }
}
