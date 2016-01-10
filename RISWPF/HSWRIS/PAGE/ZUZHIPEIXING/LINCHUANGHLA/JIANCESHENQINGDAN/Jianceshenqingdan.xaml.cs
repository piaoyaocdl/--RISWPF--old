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

namespace HSWRIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
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


        #region  -------数据处理---------------------------------------------
        //数据库
        Shujuku shujuku = new Shujuku();
        //申请单列表数据源
        private List<Zuzhipeixing_linchuanghla_jianceshenqingdanSet> shujuyuan_shenqingdanliebiao
        {
            set { shenqingdanliebiaoUI.ItemsSource = value; }
            get { return (List<Zuzhipeixing_linchuanghla_jianceshenqingdanSet>)shenqingdanliebiaoUI.ItemsSource; }
        }
        //选择的申请单
        private Zuzhipeixing_linchuanghla_jianceshenqingdanSet xuanzedeshenqingdan
        {
            get
            {
                if (shenqingdanliebiaoUI.SelectedIndex>=0)
                {
                    return (Zuzhipeixing_linchuanghla_jianceshenqingdanSet)shenqingdanliebiaoUI.SelectedItem;
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion
        #region --------事件处理--------------------------------------------
        //添加申请单
        private void shenqingdankongzhiUI_Tianjia_Click(object sender, RoutedEventArgs e)
        {
            var xin = new Zuzhipeixing_linchuanghla_jianceshenqingdanSet();
            xin.bianhao = "lsbh";
            var tianjia = new Tianjiashenqingdan();
            tianjia.shujuyuan = xin;
            tianjia.ShowDialog();
            if (tianjia.queding)
            {
                shujuku.Zuzhipeixing_linchuanghla_jianceshenqingdanSet.Add(xin);
                shujuku.SaveChanges();
                var ls = shujuku.JichuidSet.Where(j => j.biaoming.Equals("Zuzhipeixing_linchuanghla_jianceshenqingdanSet") && j.lieming.Equals("bianhao")).Single();
                var lsbianhao = (xin.id - ls.jichuid) + "";
                xin.bianhao = xin.leixing + DateTime.Now.Year + "000000".Substring(lsbianhao.Length) + lsbianhao;
                shujuku.SaveChanges();
                fenyeUI.Dangqianye = 1;
                fenyechaxun(null,null);
            }
        }

        private void shenqingdankongzhiUI_Shanchu_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan==null)
            {
                MessageBox.Show("请选择一个申请单！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            shujuku.Zuzhipeixing_linchuanghla_jianceshenqingdanSet.Remove(xuanzedeshenqingdan);
            shujuku.SaveChanges();
            fenyechaxun(null,null);
        }

        private void shenqingdankongzhiUI_Xiugai_Click(object sender, RoutedEventArgs e)
        {
            if (xuanzedeshenqingdan==null)
            {
                MessageBox.Show("请选择一个申请单！","提示",MessageBoxButton.OK,MessageBoxImage.Information);
                return;
            }
            var tianjia = new Tianjiashenqingdan();
            tianjia.shujuyuan = xuanzedeshenqingdan;
            tianjia.ShowDialog();
            if (tianjia.queding)
            {
                shujuku.SaveChanges();
            }
        }
        //页面不可见时，调用
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue)
            {
                shujuku.Dispose();
            }
        }
     
        private void chaxunUI_Click(object sender, RoutedEventArgs e)
        {
            shujuku.Dispose();
            shujuku = new Shujuku();
            fenyeUI.IsEnabled = true;
            fenyeUI.Dangqianye = 1;
            fenyechaxun(sender,e);
        }

        private void fenyechaxun(object sender, RoutedEventArgs e)
        {
            var sql = shujuku.Zuzhipeixing_linchuanghla_jianceshenqingdanSet.AsQueryable();
            if (chaxunkaishiUI.SelectedDate != null)
            {
                sql = sql.Where(z => z.jiancedanriqi >= chaxunkaishiUI.SelectedDate);
            }
            if (chaxunjieshuUI.SelectedDate != null)
            {
                sql = sql.Where(z => z.jiancedanriqi <= chaxunjieshuUI.SelectedDate);
            }
            if (chaxunhuanzhexingmingUI.Text != null && chaxunhuanzhexingmingUI.Text.Trim().Length > 0)
            {
                sql = sql.Where(z => z.huanzhexingming.Equals(chaxunhuanzhexingmingUI.Text.Trim()));
            }
            if (chaxunbianhaoUI.Text != null && chaxunbianhaoUI.Text.Trim().Length > 0)
            {
                sql = sql.Where(z => z.bianhao.Equals(chaxunbianhaoUI.Text.Trim()));
            }
            if (chaxunjiancexiangmuUI.SelectedIndex >= 0)
            {
                sql = sql.Where(z => z.leixing.Equals(chaxunjiancexiangmuUI.Text));
            }
            fenyeUI.Gongjiye = sql.Count()/20+1;
            var shuju = sql.OrderByDescending(z => z.id).Skip(fenyeUI.Dangqianye*20-20).Take(20).ToList();
            shujuyuan_shenqingdanliebiao = shuju;
        }
        #endregion

        private void liebiao_xiangxi_qiehuan(object sender, RoutedEventArgs e)
        {
            var ls = xiangxixinxikuaiUI.Visibility;
            xiangxixinxikuaiUI.Visibility = shenqingdankuaiUI.Visibility;
            shenqingdankuaiUI.Visibility = ls;
        }
    }
}
