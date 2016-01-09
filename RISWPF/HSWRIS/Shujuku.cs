namespace HSWRIS
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Shujuku : DbContext
    {
        
        public Shujuku()
            : base("name=Shujuku")
        {
        }

         public virtual DbSet<YonghuSet> YonghuSet { get; set; }
    }

    public class YonghuSet
    {
        public int Id { get; set; }
        public string zhanghao { get; set; }
        public string mima { get; set; }
    }
}