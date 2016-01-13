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
    /// Tianjiashenqingdan.xaml 的交互逻辑
    /// </summary>
    public partial class Tianjiashenqingdan : Window
    {
        public Tianjiashenqingdan()
        {
            InitializeComponent();
            queding = false;
        }

        public bool queding { set; get; }
        public Zuzhipeixing_linchuanghla_jianceshenqingdanSet shujuyuan
        {
            set { shujuyuanUI.DataContext = value; }
            get { return (Zuzhipeixing_linchuanghla_jianceshenqingdanSet)shujuyuanUI.DataContext; }
        }

        private void quedingUI_Click(object sender, RoutedEventArgs e)
        {
            if (huanzhexingmingUI.Text.Trim().Length==0)
            {
                MessageBox.Show("患者姓名不能为空！","提示",MessageBoxButton.OK,MessageBoxImage.Information);
                return;
            }
            if (shouyangriqiUI.SelectedDate == null)
            {
                MessageBox.Show("收样日期不能为空！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            queding = true;
            this.Close();
        }
    }
}
