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
            var ls1 = shujuku.JichuidSet.Where(j => j.biaoming.Equals("Zuzhipeixing_linchuanghla_jianceshenqingdanSet") && j.lieming.Equals("bianhao")).Count();
            if (ls1 < 1)
            {
                shujuku.JichuidSet.AddOrUpdate(new JichuidSet { biaoming = "Zuzhipeixing_linchuanghla_jianceshenqingdanSet", lieming = "bianhao", gengxinpinlv = "year", gengxinshijian = DateTime.Now, jichuid = 0 });
            }
            var ls2 = shujuku.JichuidSet.Where(j => j.biaoming.Equals("Zuzhipeixing_linchuanghla_yangbenSet") && j.lieming.Equals("yangbenbianhao")).Count();
            if (ls2 < 1)
            {
                shujuku.JichuidSet.AddOrUpdate(new JichuidSet { biaoming = "Zuzhipeixing_linchuanghla_yangbenSet", lieming = "yangbenbianhao", gengxinpinlv = "year", gengxinshijian = DateTime.Now, jichuid = 0 });
            }
        }
    }
}
