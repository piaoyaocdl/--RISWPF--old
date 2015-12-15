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
    /// Fenyechaxun.xaml 的交互逻辑
    /// </summary>
    public partial class Fenyechaxun : UserControl
    {
        public Fenyechaxun()
        {
            InitializeComponent();
            gongjiye = 0;
            dangqianye = 0;

            shouyeUI.IsEnabled = false;
            qianyeUI.IsEnabled = false;
            houyeUI.IsEnabled = false;
            weiyeUI.IsEnabled = false;
        }


        public event RoutedEventHandler Jichuchanxun;
        public int gongjitiao
        {
            set { gongjiye = value / meiyejitiao + 1; }
        }


        private int gongjiye
        {
            set { gongjiyeUI.Content = value; }
            get { return (int)gongjiyeUI.Content; }
        }


        public int meiyejitiao
        {
            get { return int.Parse(meiyejitiaoUI.Text); }
        }

        public int dangqianye
        {
            private set { dangqianyeUI.Content = value; }
            get
            {
                return (int)dangqianyeUI.Content;
            }
        }

        private void chaxunUI_Click(object sender, RoutedEventArgs e)
        {
            dangqianye = 1;
            Dangqianchaxun();

            shouyeUI.IsEnabled = true;
            qianyeUI.IsEnabled = true;
            houyeUI.IsEnabled = true;
            weiyeUI.IsEnabled = true;
        }

        private void weiyeUI_Click(object sender, RoutedEventArgs e)
        {
            dangqianye = gongjiye;
            Dangqianchaxun();
        }

        private void houyeUI_Click(object sender, RoutedEventArgs e)
        {
            dangqianye = Math.Min(gongjiye, dangqianye + 1);
            Dangqianchaxun();
        }

        private void qianyeUI_Click(object sender, RoutedEventArgs e)
        {
            dangqianye = Math.Max(1, dangqianye - 1);
            Dangqianchaxun();
        }

        private void shouyeUI_Click(object sender, RoutedEventArgs e)
        {
            dangqianye = 1;
            Dangqianchaxun();
        }

        public void Dangqianchaxun()
        {
            if (Jichuchanxun != null && Jichuchanxun.GetInvocationList().Length > 0)
            {
                if (dangqianye==0)
                {
                    dangqianye = 1;
                }
                Jichuchanxun(null, null);
            }
            else
            {
                MessageBox.Show("没有设置操作代码！\n用户不应该看到这个弹窗！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private  async void meiyejitiaoUI_LostFocus(object sender, RoutedEventArgs e)
        {
            int ls = -1;
            int.TryParse(meiyejitiaoUI.Text,out ls);
            if (ls<1||ls>20)
            {
                await DialogManager.ShowMessageAsync(this.TryFindParent<MetroWindow>(), "提示","请输入1-20的整数！");
                meiyejitiaoUI.Text = "10";
            }
        }
    }
}
