using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RIS.PAGE.SYST
{

    public class YonghuSet
    {
        [Key]
        public long id { set; get; }
        [Required]
        public string zhanghao { set; get; }
        [Required]
        public string mima { set; get; }
    }

    public class Shangchuanwenjian
    {
        [Key]
        public long id { set; get; }

        public string wenjianming { set; get; }

        public string daxiao { set; get; }

        public byte[] wenjian { set; get; }
    }
}
