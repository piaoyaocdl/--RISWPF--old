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

namespace HSWRIS.KONGJIAN
{
    /// <summary>
    /// Fenyechaxun.xaml 的交互逻辑
    /// </summary>
    public partial class Fenyechaxun : UserControl
    {
        public Fenyechaxun()
        {
            InitializeComponent();
            Gongjiye = 0;
            Dangqianye = 0;
        }

        public int Gongjiye
        {
            set { gongjiyeUI.Content = value; }
            get { return (int)gongjiyeUI.Content; }
        }
     
        public int Dangqianye
        {
            set { dangqianyeUI.Content = value; }
            get { return (int)dangqianyeUI.Content; }
        }

        public event RoutedEventHandler Fenye_Click;

        private void shouyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Fenye_Click != null)
            {
                Dangqianye = 1;
                Fenye_Click(sender,e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void qianyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Fenye_Click != null)
            {
                Dangqianye = Math.Max(1, Dangqianye - 1);
                Fenye_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void houyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Fenye_Click != null)
            {
                Dangqianye = Math.Min(Gongjiye, Dangqianye + 1);
                Fenye_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void weiyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Fenye_Click != null)
            {
                Dangqianye = Gongjiye;
                Fenye_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
