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
using System.Windows.Shapes;

namespace HSWRIS.PAGE.SYST
{
    /// <summary>
    /// Denglu.xaml 的交互逻辑
    /// </summary>
    public partial class Denglu : Window
    {
        public Denglu()
        {
            InitializeComponent();
        }

        private void dengluUI_Click(object sender, RoutedEventArgs e)
        {
            using (Shujuku shujuku = new Shujuku())
            {
                var ls= shujuku.YonghuSet.Where(yonghu => yonghu.zhanghao.Equals(zhanghaoUI.Text)&& yonghu.mima.Equals(mimaUI.Password)).Count();
                if (ls==1)
                {
                    Zhuchuangti zhuchuangti = new Zhuchuangti();
                    zhuchuangti.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("帐号或者密码错误！", "提示", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
