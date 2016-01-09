namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jiji : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YonghuSets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        zhanghao = c.String(),
                        mima = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YonghuSets");
        }
    }
}
