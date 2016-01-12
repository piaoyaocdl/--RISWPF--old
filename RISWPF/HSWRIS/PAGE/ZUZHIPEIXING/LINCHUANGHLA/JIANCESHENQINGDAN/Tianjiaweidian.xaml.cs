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
            if (yangben.weidians == null)
            {
                foreach (var ls in chushishuju)
                {
                    yangben.weidians.Add(ls);
                }
            }
            baoliuUI.ItemsSource = yangben.weidians.Where(z => z.jiancefou == true);
            shanchuUI.ItemsSource = yangben.weidians.Where(z => z.jiancefou == false);
        }

        private List<Zuzhipeixing_linchuanghla_weidianSet> chushishuju
        {
            get
            {
                return new List<Zuzhipeixing_linchuanghla_weidianSet>
            {
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA高分辨基因分型初筛",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="NGS",weidian="CI"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA等位基因确认分型",leixing="NGS",weidian="CII"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="NGS",weidian="CI"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA初筛转确认分型",leixing="NGS",weidian="CII"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SBT",weidian="DPB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA免费复检",leixing="SSOP",weidian="DPB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SBT",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SBT",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SBT",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SBT",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SBT",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SBT",weidian="DPB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="A"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="B"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="DRB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="C"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="DQB1"},
                new Zuzhipeixing_linchuanghla_weidianSet {jiancefou=false, fenzu="HLA单个位点基因分形",leixing="SSOP",weidian="DPB1"},
            };
            }
        }
        public bool queding { set; get; }

        public Zuzhipeixing_linchuanghla_yangbenSet yangben { set; get; }

        //删除位点
        private void shanchubtUI_Click(object sender, RoutedEventArgs e)
        {

            foreach (var ls in baoliuUI.SelectedItems)
            {
                var dangqian = (Zuzhipeixing_linchuanghla_weidianSet)ls;
                dangqian.jiancefou = false;
            }

            shuaxinshuju();
        }
        //添加位点
        private void tianjiabtUI_Click(object sender, RoutedEventArgs e)
        {

            foreach (var ls in shanchuUI.SelectedItems)
            {
                var dangqian = (Zuzhipeixing_linchuanghla_weidianSet)ls;
                dangqian.jiancefou = true;
            }
            shuaxinshuju();
        }
        //确定 退出
        private void quedingUI_Click(object sender, RoutedEventArgs e)
        {
            queding = true;
            this.Close();
        }
    }
}
