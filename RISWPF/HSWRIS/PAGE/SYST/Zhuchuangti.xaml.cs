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
using System.Windows.Shapes;

namespace HSWRIS.PAGE.SYST
{
    /// <summary>
    /// Zhuchuangti.xaml 的交互逻辑
    /// </summary>
    public partial class Zhuchuangti : Window
    {
        public Zhuchuangti()
        {
            InitializeComponent();
        }

        private void zuzhipeiing_linchuanghla_jianceshenqingdanUI_Selected(object sender, RoutedEventArgs e)
        {
            jiazaiqi.Content = new PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Jianceshenqingdan();
        }

        private void gerenzhongxinUI_Selected(object sender, RoutedEventArgs e)
        {
            jiazaiqi.Content = new PAGE.SYST.Gerenzhongxin();
        }

        private void zuzhipeiing_linchuanghla_yangbenbingdongbaocunjiluUI_Selected(object sender, RoutedEventArgs e)
        {
            jiazaiqi.Content = new PAGE.ZUZHIPEIXING.LINCHUANGHLA.YANGBENBINGDONGBAOCUNJILU.Yangbenbingdongbaocunjilu();
        }

        private void zuzhipeiing_linchuanghla_feiyongshezhiUI_Selected(object sender, RoutedEventArgs e)
        {
            jiazaiqi
        }
    }
}
