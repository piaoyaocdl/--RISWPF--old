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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace RIS.PAGE.SYST
{
    /// <summary>
    /// Zhuchuangti.xaml 的交互逻辑
    /// </summary>
    public partial class Zhuchuangti : MetroWindow
    {
        public Zhuchuangti()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
        }

        private void 个人中心_Selected(object sender, RoutedEventArgs e)
        {
            jiazaiqi.Content = new PAGE.SYST.Gerenzhongxin();
        }

        private void 组织配型_临床HLA_检测申请单_Selected(object sender, RoutedEventArgs e)
        {
            jiazaiqi.Content = new PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Jianceshenqingdan();
        }
    }
}
