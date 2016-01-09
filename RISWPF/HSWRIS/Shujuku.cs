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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //YonghuSet
            modelBuilder.Entity<YonghuSet>().HasKey(yonghu => yonghu.id);
            modelBuilder.Entity<YonghuSet>().Property(yonghu => yonghu.mima).IsRequired();
            modelBuilder.Entity<YonghuSet>().Property(yonghu => yonghu.zhanghao).IsRequired();
        }
        public virtual DbSet<YonghuSet> YonghuSet { get; set; }
    }

    public class YonghuSet
    {
        public int id { get; set; }
        public string zhanghao { get; set; }
        public string mima { get; set; }
    }
}