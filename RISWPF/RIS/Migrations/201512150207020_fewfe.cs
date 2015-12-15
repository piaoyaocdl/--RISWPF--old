namespace RIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fewfe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YonghuSets",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        zhanghao = c.String(nullable: false),
                        mima = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YonghuSets");
        }
    }
}
