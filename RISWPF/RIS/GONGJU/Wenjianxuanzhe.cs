using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.GONGJU
{
    public class Wenjianxuanzhe
    {
        /// <summary>
        /// 打开选择框
        /// </summary>
        /// <returns></returns>
        public static PAGE.SYST.WenjianshuomingSet Dakaixuanzekuang()
        {
            Microsoft.Win32.OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.InitialDirectory = @"c:\";
            op.RestoreDirectory = false;
            op.Filter = "所有文件(*.*)|*.*";
            var xuanzele=(bool)  op.ShowDialog();
            if (xuanzele)
            {
                var wenjianshuoming  = new PAGE.SYST.WenjianshuomingSet();

                wenjianshuoming.wenjianming = op.FileName.Split('\\').Last();

                var daxiao = op.OpenFile().Length/1024;
                if (daxiao>1024)
                {
                    wenjianshuoming.daxiao = (daxiao / 1024 )+ "MB";
                }
                else
                {
                    wenjianshuoming.daxiao = daxiao + "KB";
                }


                var wenjian = new PAGE.SYST.WenjianSet();
                wenjianshuoming.wenjian = wenjian;
                using (var shujuku=new Shujuku())
                {
                    shujuku.WenjianshuomingSet.Add(wenjianshuoming);
                    shujuku.WenjianSet.Add(wenjian);
                    shujuku.SaveChanges();
                }
                return wenjianshuoming;
                    
            }
            
            return null;
        }
    }
}
