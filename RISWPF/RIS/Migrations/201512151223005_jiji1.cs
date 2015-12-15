namespace RIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jiji1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zuzhipeixing_linchuanghla_yangbenSet",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        yangbenbianhao = c.String(),
                        xingming = c.String(),
                        xingbie = c.String(),
                        gonghuanguanxi = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zuzhipeixing_linchuanghla_yangbenSet");
        }
    }
}
