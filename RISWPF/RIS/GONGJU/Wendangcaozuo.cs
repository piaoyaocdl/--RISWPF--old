using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace RIS.GONGJU
{
    /// <summary>
    /// 数据库，存储的文件，操作工具类
    /// </summary>
    public class Wendangcaozuo
    {
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="shujku">数据库链接</param>
        /// <param name="wenjianshuoming"></param>
        public  static void Shanchu(Shujuku shujku, PAGE.SYST.WenjianshuomingSet wenjianshuoming)
        {
            shujku.WenjianSet.Remove(wenjianshuoming.wenjian);
            new Task<int>(shujku.SaveChanges).Start();
        }
        public static void Xiazai(PAGE.SYST.WenjianshuomingSet wenjianshuoming)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ValidateNames = true;
            sfd.FileName = wenjianshuoming.wenjianming;

            var yaoxiazai = (bool)sfd.ShowDialog();

            if (yaoxiazai)
            {
                using (var ls = sfd.OpenFile())
                {
                    ls.Write(wenjianshuoming.wenjian.wenjian, 0, wenjianshuoming.wenjian.wenjian.Length);
                }
            }
        }
    }
}
