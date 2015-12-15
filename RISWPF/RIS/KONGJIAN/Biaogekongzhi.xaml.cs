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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;


namespace RIS.KONGJIAN
{
    /// <summary>
    /// Biaogekongzhi.xaml 的交互逻辑
    /// </summary>
    public partial class Biaogekongzhi : UserControl
    {
        public Biaogekongzhi()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler Xinjia_Click;
        public event RoutedEventHandler Xiugai_Click;
        public event RoutedEventHandler Shanchu_Click;

        private async void xinjiaUI_Click(object sender, RoutedEventArgs e)
        {
            if (Xinjia_Click!=null)
            {
                Xinjia_Click(sender, e);
            }
            else
            {
                await DialogManager.ShowMessageAsync(this.TryFindParent<MetroWindow>(),"提示","没有定义此功能！");
            }
        }

        private async void xiugaiUI_Click(object sender, RoutedEventArgs e)
        {
            if (Xiugai_Click != null)
            {
                Xiugai_Click(sender, e);
            }
            else
            {
                await DialogManager.ShowMessageAsync(this.TryFindParent<MetroWindow>(), "提示", "没有定义此功能！");
            }
        }

        private async void shanchuUI_Click(object sender, RoutedEventArgs e)
        {
            if (Shanchu_Click != null)
            {
                Shanchu_Click(sender, e);
            }
            else
            {
                await DialogManager.ShowMessageAsync(this.TryFindParent<MetroWindow>(), "提示", "没有定义此功能！");
            }
        }
    }
}
