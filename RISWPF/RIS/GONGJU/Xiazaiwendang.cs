﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace RIS.GONGJU
{
    public class Xiazaiwendang
    {
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