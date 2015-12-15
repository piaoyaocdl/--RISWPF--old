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
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;

namespace RIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA
{
    /// <summary>
    /// Jianceshenqingdan.xaml 的交互逻辑
    /// </summary>
    public partial class Jianceshenqingdan : Page
    {
        public Jianceshenqingdan()
        {
            InitializeComponent();
        }

        private Shujuku shujuku = new Shujuku();
        private List<Zuzhipeixing_linchuanghla_shenqingdanSet> shenqingdanliebiao_shujuyuan
        {
            set { shenqingdanliebiaoUI.ItemsSource = value; }
            get { return (List<Zuzhipeixing_linchuanghla_shenqingdanSet>)shenqingdanliebiaoUI.ItemsSource; }
        }

        private Zuzhipeixing_linchuanghla_shenqingdanSet xuanzedeshenqingdan
        {
            get
            {
                if (shenqingdanliebiaoUI!=null && shenqingdanliebiaoUI.SelectedItem!=null)
                {
                    return (Zuzhipeixing_linchuanghla_shenqingdanSet)shenqingdanliebiaoUI.SelectedItem;
                }
                else
                {
                    return null;
                }
            }
        }

        
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void shenqingdanUI_Xinjia_Click(object sender, RoutedEventArgs e)
        {
            var tianjiachuangkou = new Tianjiayangben();
            tianjiachuangkou.shuju = new Zuzhipeixing_linchuanghla_shenqingdanSet();
            tianjiachuangkou.ShowDialog();
            shujuku.Zuzhipeixing_linchuanghla_shenqingdanSet.Add(tianjiachuangkou.shuju);
            shujuku.SaveChanges();
            fenyechaxun.Dangqianchaxun();
        }

        private async void shenqingdanUI_Xiugai_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择申请单！");
                return;
            }

            var tianjiachuangkou = new Tianjiayangben();
            tianjiachuangkou.shuju = xuanzedeshenqingdan;
            tianjiachuangkou.ShowDialog();
            shujuku.SaveChanges();
            fenyechaxun.Dangqianchaxun();
        }

        private async void shenqingdanUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan==null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow,"提示","请先选择申请单！");
                return;
            }
            shujuku.Zuzhipeixing_linchuanghla_shenqingdanSet.Remove(xuanzedeshenqingdan);
            shujuku.SaveChanges();
            fenyechaxun.Dangqianchaxun();

        }

        private void Fenyechaxun_Jichuchanxun(object sender, RoutedEventArgs e)
        {
            shujuku.Dispose();
            shujuku = new Shujuku();
            var sql = shujuku.Zuzhipeixing_linchuanghla_shenqingdanSet.AsQueryable();
            if (chaxunhuanzhexingmingUI.Text.Trim().Length>0)
            {
                sql = sql.Where(x=>x.huanzhexingming.Equals(chaxunhuanzhexingmingUI.Text.Trim()));
            }
            fenyechaxun.gongjitiao = sql.Count();
            sql = sql.OrderByDescending(x => x.id).Skip(fenyechaxun.dangqianye * fenyechaxun.meiyejitiao - fenyechaxun.meiyejitiao).Take(fenyechaxun.meiyejitiao);
            shenqingdanliebiao_shujuyuan = sql.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue==false)
            {
                shujuku.Dispose();
            }
        }

        private void yangbenkongzhiUI_Xinjia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void yangbenkongzhiUI_Xiugai_Click(object sender, RoutedEventArgs e)
        {

        }

        private void yangbenkongzhiUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
