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
            Dijiye = 0;
        }

        public int Gongjiye
        {
            set { gongjiyeUI.Content = value; }
            get { return (int)gongjiyeUI.Content; }
        }
        public int Dijiye
        {
            set { dijiyeUI.Content = value; }
            get { return (int)dijiyeUI.Content; }
        }
        public event RoutedEventHandler Shouye_Click;
        public event RoutedEventHandler Qianye_Click;
        public event RoutedEventHandler Houye_Click;
        public event RoutedEventHandler Weiye_Click;

        private void shouyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Shouye_Click!=null)
            {
                Shouye_Click(sender,e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void qianyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Qianye_Click != null)
            {
                Qianye_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void houyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Houye_Click != null)
            {
                Houye_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void weiyeUI_Click(object sender, RoutedEventArgs e)
        {
            if (Weiye_Click != null)
            {
                Weiye_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
