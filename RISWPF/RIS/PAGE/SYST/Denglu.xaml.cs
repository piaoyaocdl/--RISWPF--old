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
    /// Denglu.xaml 的交互逻辑
    /// </summary>
    public partial class Denglu : MetroWindow
    {
        public Denglu()
        {
            InitializeComponent();
#if DEBUG
            var zhuchuangti = new PAGE.SYST.Zhuchuangti();
            zhuchuangti.Show();
            this.Close();
#endif
        }

        private async void  dengluUI_Click(object sender, RoutedEventArgs e)
        {
            using (var shujuku=new Shujuku())
            {
                var ls = shujuku.YonghuSet.Where(x=>x.zhanghao.Equals(zhanghaoUI.Text)&&x.mima.Equals(mimaUI.Password)).Count();
                if (ls==1)
                {
                    var zhuchuangti = new PAGE.SYST.Zhuchuangti();
                    zhuchuangti.Show();
                    this.Close();
                }
                else
                {
                    await this.ShowMessageAsync("提示", "帐号或者密码错误！");
                }
            }
        }
    }
}
