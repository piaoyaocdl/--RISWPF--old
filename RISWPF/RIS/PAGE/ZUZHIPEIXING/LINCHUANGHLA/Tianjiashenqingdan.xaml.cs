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

namespace RIS.PAGE.ZUZHIPEIXING.LINCHUANGHLA
{
    /// <summary>
    /// Tianjiashenqingdan.xaml 的交互逻辑
    /// </summary>
    public partial class Tianjiayangben : MetroWindow
    {
        public Tianjiayangben()
        {
            InitializeComponent();
        }

        public Zuzhipeixing_linchuanghla_shenqingdanSet shuju
        {
            set { shujuUI.DataContext = value; }
            get { return (Zuzhipeixing_linchuanghla_shenqingdanSet)shujuUI.DataContext; }
        }
    }
}
