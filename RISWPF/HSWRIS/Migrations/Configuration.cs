namespace HSWRIS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<HSWRIS.Shujuku>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HSWRIS.Shujuku shujuku)
        {
            var guanliyuan = new YonghuSet { zhanghao = "ceshi", mima = "ceshi" };
            if (shujuku.YonghuSet.Where(z=>z.zhanghao.Equals(guanliyuan.zhanghao)).Count()==0)
            {
                shujuku.YonghuSet.Add(guanliyuan);
                shujuku.SaveChanges();
            }

            var jiancedan = new JichuidSet { biaoming = "Zuzhipeixing_linchuanghla_jianceshenqingdanSet", lieming = "bianhao", gengxinpinlv = "year", gengxinshijian = DateTime.Now, jichuid = 0 };
            if (shujuku.JichuidSet.Where(z=>z.biaoming.Equals(jiancedan.biaoming)&&z.lieming.Equals(jiancedan.lieming)).Count()==0)
            {
                shujuku.JichuidSet.Add(jiancedan);
                shujuku.SaveChanges();
            }

            var yangben = new JichuidSet { biaoming = "Zuzhipeixing_linchuanghla_yangbenSet", lieming = "yangbenbianhao", gengxinpinlv = "year", gengxinshijian = DateTime.Now, jichuid = 0 };
            if (shujuku.JichuidSet.Where(z=>z.biaoming.Equals(yangben.biaoming)&&z.lieming.Equals(yangben.lieming)).Count()==0)
            {
                shujuku.JichuidSet.Add(yangben);
                shujuku.SaveChanges();
            }

            var guanliyuanjuese = new JueseSet { jueseming = "guanliyuan", shuoming = "管理员" };
            if (shujuku.JueseSet.Where(z=>z.jueseming.Equals(guanliyuanjuese.jueseming)).Count()==0)
            {
                guanliyuanjuese.yonghus.Add(guanliyuan);
                shujuku.JueseSet.Add(guanliyuanjuese);
                shujuku.SaveChanges();
            }

            var putongjuese = new JueseSet { jueseming = "putongyonghu", shuoming = "普通用户" };
            if (shujuku.JueseSet.Where(z=>z.jueseming.Equals(putongjuese.jueseming)).Count()==0)
            {
                shujuku.JueseSet.Add(putongjuese);
                shujuku.SaveChanges();
            }
        }
    }
}
