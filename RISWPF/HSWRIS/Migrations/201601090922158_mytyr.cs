namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mytyr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JichuidSets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        biaoming = c.String(nullable: false),
                        lieming = c.String(nullable: false),
                        zifenlei = c.String(),
                        gengxinpinlv = c.String(nullable: false),
                        gengxinshijian = c.DateTime(nullable: false),
                        jichuid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "bianhao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zuzhipeixing_linchuanghla_jianceshenqingdanSet", "bianhao");
            DropTable("dbo.JichuidSets");
        }
    }
}
