using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
namespace HSWRIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{

    public class Zuzhipeixing_linchuanghla_weidianSet
    {
        public int id { set; get; }

        public string fenzu { set; get; }
        public string leixing { set; get; }
        public string weidian { set; get; }
        public string beizhu { set; get; }

        public Zuzhipeixing_linchuanghla_yangbenSet yangben { set; get; }

        public bool xiangtong(Zuzhipeixing_linchuanghla_weidianSet z)
        {
            if (z.fenzu.Equals(this.fenzu)&&z.leixing.Equals(this.leixing)&&z.weidian.Equals(this.weidian))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Zuzhipeixing_linchuanghla_yangbenSet
    {

        public int id { set; get; }

        public string yuanshibianhao { set; get; }//原始编号
        public string xingming { set; get; }//姓名
        public string xingbie { set; get; }//性别
        public Nullable<DateTime> chushengriqi { set; get; }//出生日期
        public string leixing { set; get; }//类型
        public string yangbenbianhao { set; get; }//样本编号
        public Nullable<bool> huanzhebenren { set; get; }//患者本人
        public string gonghuanguanxi { set; get; }//共患关系
        public string songjiandanwei { set; get; }//送检单位
        public string yangbenleixing { set; get; }//样本类型
        public Nullable<int> yangguanshu { set; get; }//样管数
        public Nullable<bool> yangbenhege { set; get; }//样本合格
        public Nullable<DateTime> caiyangriqi { set; get; }//采样日期
        public Nullable<DateTime> shouyangriqi { set; get; }//收样日期
        public Nullable<DateTime> fufeiriqi { set; get; }//付费日期
        public string shouyangzhe { set; get; }//收样者
        public Nullable<DateTime> jianceriqi { set; get; }//检测日期
        public string beizhu { set; get; }//备注

        public Zuzhipeixing_linchuanghla_jianceshenqingdanSet shenqingdan { get; set; }
        public virtual ICollection<Zuzhipeixing_linchuanghla_weidianSet> weidians { set; get; }
    }

    public class Zuzhipeixing_linchuanghla_jianceshenqingdanSet
    {
        public int id { set; get; }
        public string leixing { set; get; }
        public string bianhao { set; get; }
        public string huanzhexingming { set; get; }
        public string xingbie { set; get; }
        public string shenfenzhenghao { set; get; }
        public string linchuangzhenduan { set; get; }
        public string chuanghao { set; get; }
        public string shenqingyiyuan { set; get; }
        public string shenqingyisheng { set; get; }
        public string zhuyuanhao { set; get; }
        public string baogaofasongfangshi { set; get; }
        public string lianxidianhua { set; get; }
        public string fax { set; get; }
        public string email { set; get; }
        public string youbian { set; get; }
        public string tongxundizhi { set; get; }
        public string shouyangzhe { set; get; }
        public string beizhu { set; get; }

        public Nullable<DateTime> chushengriqi { set; get; }
        public Nullable<DateTime> caiyangriqi { set; get; }
        public Nullable<DateTime> shouyangriqi { set; get; }
        public Nullable<DateTime> jiancedanriqi { set; get; }
        public Nullable<bool> zhuyuan { set; get; }
        public Nullable<bool> menzhen { set; get; }

        public virtual ICollection<Zuzhipeixing_linchuanghla_yangbenSet> yangbens { get; set; }
    }
}
