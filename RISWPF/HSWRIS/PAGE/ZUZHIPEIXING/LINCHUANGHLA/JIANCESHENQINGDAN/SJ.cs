using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSWRIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{
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
    }
}
