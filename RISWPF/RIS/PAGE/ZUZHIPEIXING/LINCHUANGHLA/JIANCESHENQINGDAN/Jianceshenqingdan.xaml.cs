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

namespace RIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{
    /// <summary>
    /// Jianceshenqingdan.xaml 的交互逻辑
    /// </summary>
    public partial class Jianceshenqingdan : Page
    {
        public Jianceshenqingdan()
        {
            InitializeComponent();
            wendangkongzhiUI.xiugaiUI.Content = "下载";
            wendangkongzhiUI.xinjiaUI.Content = "上传";
        }

        private Shujuku shujuku = new Shujuku();
        private List<Zuzhipeixing_linchuanghla_shenqingdanSet> shenqingdanliebiao_shujuyuan
        {
            set
            {
                yangben_shujuyuan = null;
                wendang_shujuyuan = null;
                shenqingdanliebiaoUI.ItemsSource = value;
            }
            get { return (List<Zuzhipeixing_linchuanghla_shenqingdanSet>)shenqingdanliebiaoUI.ItemsSource; }
        }

        private Zuzhipeixing_linchuanghla_shenqingdanSet xuanzedeshenqingdan
        {
            get
            {
                if (shenqingdanliebiaoUI != null && shenqingdanliebiaoUI.SelectedItem != null)
                {
                    return (Zuzhipeixing_linchuanghla_shenqingdanSet)shenqingdanliebiaoUI.SelectedItem;
                }
                else
                {
                    return null;
                }
            }
        }
        private PAGE.SYST.WenjianshuomingSet xuanzedewenjian
        {
            get
            {
                if (wendangUI != null && wendangUI.SelectedItem != null)
                {
                    return (PAGE.SYST.WenjianshuomingSet)wendangUI.SelectedItem;
                }
                else
                {
                    return null;
                }
            }
        }

        private List<Zuzhipeixing_linchuanghla_yangbenSet> yangben_shujuyuan
        {
            set { yangbenUI.ItemsSource = value; }
            get { return (List<Zuzhipeixing_linchuanghla_yangbenSet>)yangbenUI.ItemsSource; }
        }
        private Zuzhipeixing_linchuanghla_yangbenSet xuanzedeyangben
        {
            get
            {
                if (yangbenUI != null && yangbenUI.SelectedItem != null)
                {
                    return (Zuzhipeixing_linchuanghla_yangbenSet)yangbenUI.SelectedItem;
                }
                else
                {
                    return null;
                }
            }
        }

        private List<PAGE.SYST.WenjianshuomingSet> wendang_shujuyuan
        {
            set { wendangUI.ItemsSource = value; }
            get { return (List<PAGE.SYST.WenjianshuomingSet>)wendangUI.ItemsSource; }
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void shenqingdanUI_Xinjia_Click(object sender, RoutedEventArgs e)
        {
            var tianjiachuangkou = new Tianjiashenqingdan();
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

            var tianjiachuangkou = new Tianjiashenqingdan();
            tianjiachuangkou.shuju = xuanzedeshenqingdan;
            tianjiachuangkou.ShowDialog();
            shujuku.SaveChanges();
            fenyechaxun.Dangqianchaxun();
        }

        private async void shenqingdanUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择申请单！");
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
            if (chaxunhuanzhexingmingUI.Text.Trim().Length > 0)
            {
                sql = sql.Where(x => x.huanzhexingming.Equals(chaxunhuanzhexingmingUI.Text.Trim()));
            }
            fenyechaxun.gongjitiao = sql.Count();
            sql = sql.OrderByDescending(x => x.id).Skip(fenyechaxun.dangqianye * fenyechaxun.meiyejitiao - fenyechaxun.meiyejitiao).Take(fenyechaxun.meiyejitiao);
            shenqingdanliebiao_shujuyuan = sql.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == false)
            {
                shujuku.Dispose();
            }
        }

        private async void yangbenkongzhiUI_Xinjia_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择申请单！");
                return;
            }
            var tianjiayangben = new Tianjiayangben();
            tianjiayangben.shuju = new Zuzhipeixing_linchuanghla_yangbenSet();
            tianjiayangben.shuju.shenqingdan = xuanzedeshenqingdan;
            tianjiayangben.ShowDialog();
            shujuku.Zuzhipeixing_linchuanghla_yangbenSet.Add(tianjiayangben.shuju);
            shujuku.SaveChanges();
            yangben_shujuyuan = xuanzedeshenqingdan.yangbens.ToList();

        }

        private async void yangbenkongzhiUI_Xiugai_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeyangben == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择样本！");
                return;
            }
            var tianjiayangben = new Tianjiayangben();
            tianjiayangben.shuju = xuanzedeyangben;
            tianjiayangben.ShowDialog();
            shujuku.SaveChanges();
            yangben_shujuyuan = xuanzedeshenqingdan.yangbens.ToList();
        }

        private async void yangbenkongzhiUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeyangben == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择样本！");
                return;
            }
            shujuku.Zuzhipeixing_linchuanghla_yangbenSet.Remove(xuanzedeyangben);
            shujuku.SaveChanges();
            yangben_shujuyuan = xuanzedeshenqingdan.yangbens.ToList();
        }

        private void shenqingdanliebiaoUI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (xuanzedeshenqingdan != null)
            {
                yangben_shujuyuan = xuanzedeshenqingdan.yangbens.ToList();
                wendang_shujuyuan = xuanzedeshenqingdan.wendangs.ToList();
            }
        }

        private async void wendangkongzhiUI_Xinjia_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择申请单！");
                return;
            }
            var tianjianwenjian = new PAGE.SYST.Tianjiawenjian();
            tianjianwenjian.ShowDialog();
            if (tianjianwenjian.Wenjianshuoming != null)
            {
                shujuku.WenjianSet.Add(tianjianwenjian.Wenjianshuoming.wenjian);
                xuanzedeshenqingdan.wendangs.Add(tianjianwenjian.Wenjianshuoming);
                shujuku.SaveChanges();
            }
            wendang_shujuyuan = xuanzedeshenqingdan.wendangs.ToList();
        }

        private async void wendangkongzhiUI_Xiugai_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedewenjian == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择文件！");
                return;
            }
            GONGJU.Xiazaiwendang.Xiazai(xuanzedewenjian);
        }

        private async  void wendangkongzhiUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedewenjian == null)
            {
                await DialogManager.ShowMessageAsync((MetroWindow)Application.Current.MainWindow, "提示", "请先选择文件！");
                return;
            }
            shujuku.WenjianshuomingSet.Remove(xuanzedewenjian);
            shujuku.SaveChanges();
            wendang_shujuyuan = xuanzedeshenqingdan.wendangs.ToList();
        }
    }
}
