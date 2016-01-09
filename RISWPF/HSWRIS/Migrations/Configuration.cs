namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HSWRIS.Shujuku>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HSWRIS.Shujuku shujuku)
        {
            var ls = shujuku.YonghuSet.Where(yong => yong.zhanghao.Equals("ceshi") && yong.mima.Equals("ceshi")).Count();
            if (ls < 1)
            {
                shujuku.YonghuSet.AddOrUpdate(new YonghuSet { zhanghao = "ceshi", mima = "ceshi" });
            }
        }
    }
}
