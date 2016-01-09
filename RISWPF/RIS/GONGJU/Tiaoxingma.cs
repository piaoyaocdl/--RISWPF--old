using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ZXing;
namespace RIS.GONGJU
{
    /// <summary>
    /// 条形码工具
    /// </summary>
    public class Tiaoxingma
    {
        /// <summary>
        /// 转条形码编号，到，word可插入的条形码图片
        /// </summary>
        /// <param name="mahao"></param>
        /// <returns></returns>
        public static string Base64tiaoxingma(string mahao)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.EAN_13;
            writer.Options.PureBarcode = true;
            Bitmap bt = writer.Write(mahao);

            string re;
            using (MemoryStream ms = new MemoryStream())
            {
                bt.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                re = Convert.ToBase64String(arr);
            }

            return re;
        }
    }
}
