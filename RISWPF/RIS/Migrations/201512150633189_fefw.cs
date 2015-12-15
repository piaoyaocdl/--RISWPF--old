namespace RIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fefw : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_shenqingdanSet",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        shenqingdanbianhao = c.String(),
                        huanzhexingming = c.String(),
                        xingbie = c.String(),
                        chushengriqi = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zuzhipeixing_linchuanghla_shenqingdanSet");
        }
    }
}
