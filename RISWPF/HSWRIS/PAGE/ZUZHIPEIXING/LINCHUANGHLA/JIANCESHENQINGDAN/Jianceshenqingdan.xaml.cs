using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HSWRIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{
    /// <summary>
    /// Jianceshenqingdan.xaml 的交互逻辑
    /// </summary>
    public partial class Jianceshenqingdan : Page
    {
        public Jianceshenqingdan()
        {
            InitializeComponent();
        }

        //--------数据处理--------------------------------------------
        Shujuku shujuku = new Shujuku();

        //--------事件处理--------------------------------------------
        private void shenqingdankongzhiUI_Tianjia_Click(object sender, RoutedEventArgs e)
        {
            var xin = new Zuzhipeixing_linchuanghla_jianceshenqingdanSet();
            var tianjia = new Tianjiashenqingdan();
            tianjia.shujuyuan = xin;
            tianjia.ShowDialog();
            if (tianjia.queding)
            {
                shujuku.Zuzhipeixing_linchuanghla_jianceshenqingdanSet.Add(xin);
                shujuku.SaveChanges();
                var ls=shujuku.JichuidSet.Where(j => j.biaoming.Equals("Zuzhipeixing_linchuanghla_jianceshenqingdanSet") && j.lieming.Equals("bianhao")).Single();
                var lsbianhao = (xin.id - ls.jichuid) + "";
                xin.bianhao = xin.leixing + DateTime.Now.Year + "000000".Substring(lsbianhao.Length)+lsbianhao;
                shujuku.SaveChanges();
            }
        }

        private void shenqingdankongzhiUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void shenqingdankongzhiUI_Xiugai_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue)
            {
                shujuku.Dispose(); 
            }
        }
    }
}
