namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fefw : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yuanshibianhao", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "xingming", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "xingbie", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushengriqi", c => c.DateTime());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "leixing", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenbianhao", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "huanzhebeiren", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gonghuanguanxi", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "songjiandanwei", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenleixing", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangguanshu", c => c.Int());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenhege", c => c.Boolean());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "caiyangriqi", c => c.DateTime());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangriq", c => c.DateTime());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "fufeiriqi", c => c.DateTime());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangzhe", c => c.String());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "jianceriqi", c => c.DateTime());
            AddColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "beizhu", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "beizhu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "jianceriqi");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangzhe");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "fufeiriqi");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "shouyangriq");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "caiyangriqi");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenhege");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangguanshu");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenleixing");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "songjiandanwei");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "gonghuanguanxi");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "huanzhebeiren");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yangbenbianhao");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "leixing");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "chushengriqi");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "xingbie");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "xingming");
            DropColumn("dbo.Zuzhipeixing_linchuanghla_yangbenSet", "yuanshibianhao");
        }
    }
}
