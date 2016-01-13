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

            var ls3 = shujuku.JueseSet.Where(j => j.jueseming.Equals("guanliyuan") && j.shuoming.Equals("管理员")).Count();
            if (ls3 < 1)
            {
                shujuku.JueseSet.AddOrUpdate(new JueseSet { jueseming = "guanliyuan", shuoming = "管理员" });
            }
            var ls4 = shujuku.JueseSet.Where(j => j.jueseming.Equals("putongyonghu") && j.shuoming.Equals("普通用户")).Count();
            if (ls4 < 1)
            {
                shujuku.JueseSet.AddOrUpdate(new JueseSet { jueseming = "putongyonghu", shuoming = "普通用户" });
            }
            shujuku.SaveChanges();
            var guanliyuanjs = shujuku.JueseSet.Where(j => j.jueseming.Equals("guanliyuan") && j.shuoming.Equals("管理员")).Single();
            var guanliyuanyu = shujuku.YonghuSet.Where(yong => yong.zhanghao.Equals("ceshi") && yong.mima.Equals("ceshi")).Single();
            if (!guanliyuanyu.jueses.Contains(guanliyuanjs))
            {
                guanliyuanyu.jueses.Add(guanliyuanjs);
                shujuku.SaveChanges();
            } 



        }
    }
}
