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
using System.IO;

namespace RIS.PAGE.SYST
{
    /// <summary>
    /// Tianjiashenqingdan.xaml 的交互逻辑
    /// </summary>
    public partial class Tianjiawenjian : MetroWindow
    {
        public Tianjiawenjian()
        {
            InitializeComponent();
            Wenjianshuoming = null;
            Wenjian = null;
        }

        public PAGE.SYST.WenjianshuomingSet Wenjianshuoming{ set; get; }

        private PAGE.SYST.WenjianSet Wenjian { set; get; }

        private void xuanzewenjianUI_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.InitialDirectory = @"c:\";
            op.RestoreDirectory = true;
            op.Filter = "所有文件(*.*)|*.*";
            var xuanzele = (bool)op.ShowDialog();

            if (xuanzele)
            {
                Wenjianshuoming = new PAGE.SYST.WenjianshuomingSet();
                Wenjianshuoming.wenjianming = op.FileName.Split('\\').Last();
                var daxiao = op.OpenFile().Length / 1024;
                if (daxiao > 1024)
                {
                    Wenjianshuoming.daxiao = (daxiao / 1024) + "MB";
                }
                else
                {
                    Wenjianshuoming.daxiao = daxiao + "KB";
                }


                Wenjian = new PAGE.SYST.WenjianSet();
                Wenjian.wenjian = new byte[op.OpenFile().Length];
                using (var ls= op.OpenFile())
                {
                    ls.Read(Wenjian.wenjian, 0, (int)op.OpenFile().Length);
                }
                Wenjianshuoming.wenjian = Wenjian ;

                shujuUI.DataContext = Wenjianshuoming;
                beizhuUI.IsReadOnly = false;
            }
        }
    }
}
