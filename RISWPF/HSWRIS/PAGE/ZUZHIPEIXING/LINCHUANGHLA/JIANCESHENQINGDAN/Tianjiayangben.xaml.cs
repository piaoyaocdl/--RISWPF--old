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

namespace HSWRIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{
    /// <summary>
    /// Tianjiayangben.xaml 的交互逻辑
    /// </summary>
    public partial class Tianjiayangben : Window
    {
        public Tianjiayangben()
        {
            InitializeComponent();
            queding = false;
        }

        public Zuzhipeixing_linchuanghla_yangbenSet shujuyuan
        {
            set
            {
                yangbenUI.DataContext = value;
            }
            get
            {
                return (Zuzhipeixing_linchuanghla_yangbenSet)yangbenUI.DataContext;
            }
        }
        public bool queding { set; get; }

        private void quedingUI_Click(object sender, RoutedEventArgs e)
        {
            if (xingmingUI.Text.Trim().Length < 1)
            {
                MessageBox.Show("姓名不能为空！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (leixingUI.SelectedIndex< 0)
            {
                MessageBox.Show("SZ/FY不能为空！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            queding = true;
            this.Close();
        }
    }
}
