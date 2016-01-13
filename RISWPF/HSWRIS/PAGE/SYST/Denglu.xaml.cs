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

            //更新 jichuid 表
            using (Shujuku shujuku = new Shujuku())
            {
                var ls = shujuku.JichuidSet.Where(j => j.biaoming.Equals("Zuzhipeixing_linchuanghla_jianceshenqingdanSet") && j.lieming.Equals("bianhao")).Single();
                if (ls.gengxinshijian.Year != DateTime.Now.Year)
                {
                    ls.gengxinshijian = DateTime.Now;
                    var zuidaid = shujuku.Zuzhipeixing_linchuanghla_jianceshenqingdanSet.Max(z => z.id);
                    ls.jichuid = zuidaid;
                    shujuku.SaveChanges();
                }

                var ls1 = shujuku.JichuidSet.Where(j => j.biaoming.Equals("Zuzhipeixing_linchuanghla_yangbenSet") && j.lieming.Equals("yangbenbianhao")).Single();
                if (ls1.gengxinshijian.Year != DateTime.Now.Year)
                {
                    ls1.gengxinshijian = DateTime.Now;
                    var zuidaid = shujuku.Zuzhipeixing_linchuanghla_yangbenSet.Max(z => z.id);
                    ls1.jichuid = zuidaid;
                    shujuku.SaveChanges();
                }
            }
        }

        private void dengluUI_Click(object sender, RoutedEventArgs e)
        {
            using (Shujuku shujuku = new Shujuku())
            {
                var ls = shujuku.YonghuSet.Where(yonghu => yonghu.zhanghao.Equals(zhanghaoUI.Text) && yonghu.mima.Equals(mimaUI.Password)).Count();
                if (ls == 1)
                {
                    App.dangqianyonghu = shujuku.YonghuSet.Where(yonghu => yonghu.zhanghao.Equals(zhanghaoUI.Text) && yonghu.mima.Equals(mimaUI.Password)).Single();
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
