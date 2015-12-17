using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace CeShi01
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Parse(CeShi01.Properties.Resources.HLA);
            root.Descendants();

            FileStream aFile = new FileStream(@"C:\Users\HSWC\Desktop\2222.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            foreach (var ls in root.Descendants())
            {
                if (ls.Attribute("id")!=null&&ls.Attribute("id").Value.Equals("hang"))
                {
                    sw.Write(ls.ToString());
                    sw.Write("\n+++++++++++++++++++++++++++++++++++\n");
                }
            }
            sw.Write("+++++++++++++++++++++++++++++++++++\n");
            sw.Write("+++++++++++++++++++++++++++++++++++\n");
            sw.Write("+++++++++++++++++++++++++++++++++++\n");
            sw.Write("+++++++++++++++++++++++++++++++++++\n");
            sw.Close();

        }
    }
}
