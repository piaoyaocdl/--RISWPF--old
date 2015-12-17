using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Win32;

namespace RIS.GONGJU
{
    public class XMLcaozuo
    {
        public static XElement FindByNeirong(XElement root, string neirong)
        {
            foreach (var jiedian in root.Descendants())
            {
                if (jiedian.Descendants().Count() == 0 && jiedian.Value.Equals(neirong))
                {
                    return jiedian;
                }
            }
            return null;
        }

        public static XElement FindById(XElement root, string idneirong)
        {
            foreach (var jiedian in root.Descendants())
            {
                if (jiedian.Attribute("id") != null && jiedian.Attribute("id").Value.Equals(idneirong))
                {
                    return jiedian;
                }
            }
            return null;
        }

        public static void BaocunXML(XElement root, string wenjianming)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ValidateNames = true;
            sfd.FileName = wenjianming;

            var yaoxiazai = (bool)sfd.ShowDialog();

            if (yaoxiazai)
            {
                using (var ls = sfd.OpenFile())
                {
                    string xmlbanben = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\n<?mso-application progid = \"Word.Document\" ?> \n ";
                    var Wendang = Encoding.UTF8.GetBytes(xmlbanben+  root.ToString());
                    ls.Write(Wendang, 0, Wendang.Length);
                }
            }
        }
    }
}
