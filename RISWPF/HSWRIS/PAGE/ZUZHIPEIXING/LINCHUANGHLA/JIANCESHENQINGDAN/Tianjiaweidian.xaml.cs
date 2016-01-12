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

namespace HSWRIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN
{
    /// <summary>
    /// Tianjiaweidian.xaml 的交互逻辑
    /// </summary>
    public partial class Tianjiaweidian : Window
    {
        public Tianjiaweidian()
        {
            InitializeComponent();
            queding = false;
        }

        //刷新列表数据
        public void shuaxinshuju()
        {
            baoliuUI.ItemsSource = null;
            baoliuUI.ItemsSource = yangben.weidians;
            var lsliebiao = new List<Zuzhipeixing_linchuanghla_weidianSet>();
            foreach (var ls in chushishuju)
            {
                if (yangben.weidians==null||yangben.weidians.Where(z => z.xiangtong(ls)).Count() == 0)
                {
                    lsliebiao.Add(ls);
                }
            }
            shanchuUI.ItemsSource = null;
            shanchuUI.ItemsSource = lsliebiao;
        }

        private List<Zuzhipeixing_linchuanghla_weidianSet> chushishuju
        = new List<Zuzhipeixing_linchuanghla_weidianSet>
            {
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="NGS",weidian="CI"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA等位基因确认分型",leixing="NGS",weidian="CII"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="NGS",weidian="CI"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA初筛转确认分型",leixing="NGS",weidian="CII"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SBT",weidian="DPB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA免费复检",leixing="SSOP",weidian="DPB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SBT",weidian="DPB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet { fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="DPB1"},
        };
        public bool queding { set; get; }

        public Zuzhipeixing_linchuanghla_yangbenSet yangben { set; get; }
        public Shujuku shujuku { set; get; }

        //删除位点
        private void shanchubtUI_Click(object sender, RoutedEventArgs e)
        {

            foreach (var ls in baoliuUI.SelectedItems)
            {
                var dangqian = (Zuzhipeixing_linchuanghla_weidianSet)ls;
                yangben.weidians.Remove(dangqian);
                shujuku.Zuzhipeixing_linchuanghla_weidianSet.Remove(dangqian);
            }
            shuaxinshuju();
        }
        //添加位点
        private void tianjiabtUI_Click(object sender, RoutedEventArgs e)
        {

            foreach (var ls in shanchuUI.SelectedItems)
            {
                var dangqian = (Zuzhipeixing_linchuanghla_weidianSet)ls;
                yangben.weidians.Add(dangqian);
            }
            shuaxinshuju();
        }
        //确定 退出
        private void quedingUI_Click(object sender, RoutedEventArgs e)
        {
            queding = true;
            this.Close();
        }
        //保留数据 选择变换
        private void baoliuUI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (baoliuUI.SelectedItems.Count==1)
            {
                beizhuUI.Text = ((Zuzhipeixing_linchuanghla_weidianSet)baoliuUI.SelectedItem).beizhu;
            }
            else
            {
                beizhuUI.Text = "";
            }
        }

        private void beizhuUI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (baoliuUI.SelectedItems.Count == 1)
            {
                 ((Zuzhipeixing_linchuanghla_weidianSet)baoliuUI.SelectedItem).beizhu= beizhuUI.Text;
                shuaxinshuju();
            }
        }
    }
}
