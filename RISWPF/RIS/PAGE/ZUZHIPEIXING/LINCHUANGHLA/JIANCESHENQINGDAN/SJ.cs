using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{

    public class Zuzhipeixing_linchuanghla_yangbenSet
    {
        [Key]
        public long id { set; get; }
        public string yangbenbianhao { set; get; }
        public string xingming { set; get; }
        public string xingbie { set; get; }
        public string gonghuanguanxi { set; get; }

        [ForeignKey("shenqingdan")]
        public long shenqingdanid { set; get; }
       
        public virtual Zuzhipeixing_linchuanghla_shenqingdanSet shenqingdan { set; get; }
    }

    public class Zuzhipeixing_linchuanghla_shenqingdanSet
    {
        [Key]
        public long id { set; get; }
        public string shenqingdanbianhao { set; get; }
        public string huanzhexingming { set; get; }
        public string xingbie { set; get; }
        public Nullable<DateTime> chushengriqi { set; get; }

        public virtual ICollection<Zuzhipeixing_linchuanghla_yangbenSet> yangbens { set; get; }
    }
}
