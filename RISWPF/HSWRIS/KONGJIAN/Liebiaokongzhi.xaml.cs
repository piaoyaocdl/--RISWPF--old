﻿using System;
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
    /// Liebiaokongzhi.xaml 的交互逻辑
    /// </summary>
    public partial class Liebiaokongzhi : UserControl
    {
        public Liebiaokongzhi()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler Tianjia_Click;
        public event RoutedEventHandler Xiugai_Click;
        public event RoutedEventHandler Shanchu_Click;

        private void tianjiaUI_Click(object sender, RoutedEventArgs e)
        {
            if (Tianjia_Click!=null)
            {
                Tianjia_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！","提示",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void xiugaiUI_Click(object sender, RoutedEventArgs e)
        {
            if (Xiugai_Click != null)
            {
                Xiugai_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void shanchuUI_Click(object sender, RoutedEventArgs e)
        {
            if (Shanchu_Click != null)
            {
                Shanchu_Click(sender, e);
            }
            else
            {
                MessageBox.Show("此功能没有实现！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
