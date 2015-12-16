using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CeShi01
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load("REPORT/shiyan.xml");
            Console.WriteLine(root.ToString());
        }
    }
}
