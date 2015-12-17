using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RIS.REPORT
{
    public class HLA
    {
        public static void Dayinbaobiao( PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_shenqingdanSet xuanzedeshenqingdan  )
        {
            XElement moban = XElement.Parse(RIS.Properties.Resources.HLA);
            GONGJU.XMLcaozuo.FindByNeirong(moban, "患者姓名替换").Value = xuanzedeshenqingdan.huanzhexingming;
            GONGJU.XMLcaozuo.FindByNeirong(moban, "性别替换").Value = xuanzedeshenqingdan.xingbie;
            GONGJU.XMLcaozuo.FindByNeirong(moban, "出生日期替换").Value = xuanzedeshenqingdan.chushengriqi.ToString().Substring(0, 10);
            GONGJU.XMLcaozuo.FindByNeirong(moban, "申请单编号替换").Value = xuanzedeshenqingdan.shenqingdanbianhao;

            var yangbenhang = GONGJU.XMLcaozuo.FindById(moban, "yangbenhang");
            foreach (var yangben in xuanzedeshenqingdan.yangbens)
            {
                var ls = XElement.Parse(yangbenhang.ToString());
                GONGJU.XMLcaozuo.FindByNeirong(ls, "样本编号替换").Value = yangben.yangbenbianhao;
                GONGJU.XMLcaozuo.FindByNeirong(ls, "姓名替换").Value = yangben.xingming;
                GONGJU.XMLcaozuo.FindByNeirong(ls, "性别替换").Value = yangben.xingbie;
                GONGJU.XMLcaozuo.FindByNeirong(ls, "共患关系替换").Value = yangben.gonghuanguanxi;
                yangbenhang.AddAfterSelf(ls);
            }
            yangbenhang.Remove();
            GONGJU.XMLcaozuo.BaocunXML(moban, xuanzedeshenqingdan.huanzhexingming + "-" + xuanzedeshenqingdan.shenqingdanbianhao + ".doc");
        }
    }
}
