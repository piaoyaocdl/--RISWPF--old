namespace HSWRIS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;
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
            var yonghuSet = modelBuilder.Entity<YonghuSet>();
            yonghuSet.HasKey(yonghu => yonghu.id);
            yonghuSet.Property(yonghu => yonghu.mima).IsRequired();
            yonghuSet.Property(yonghu => yonghu.zhanghao).IsRequired();

            //JichuidSet
            var jichuidset = modelBuilder.Entity<JichuidSet>();
            jichuidset.HasKey(j => j.id);
            jichuidset.Property(j => j.biaoming).IsRequired();
            jichuidset.Property(j => j.lieming).IsRequired();
            jichuidset.Property(j => j.gengxinpinlv).IsRequired();
            jichuidset.Property(j => j.gengxinshijian).IsRequired();
            jichuidset.Property(j => j.jichuid).IsRequired();

            //Zuzhipeixing_linchuanghla_jianceshenqingdanSet
            var zuzhipeixing_linchuanghla_jianceshenqingdanSet = modelBuilder.Entity<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_jianceshenqingdanSet>();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.HasKey(z => z.id);
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.Property(z => z.huanzhexingming).IsRequired();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.Property(z => z.shouyangriqi).IsRequired();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.Property(z => z.leixing).IsRequired();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.Property(z => z.bianhao).IsRequired().HasMaxLength(50).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_bianhao_weiyi") { IsUnique = true })); ;
        }
        public virtual DbSet<YonghuSet> YonghuSet { get; set; }
        public virtual DbSet<JichuidSet> JichuidSet { get; set; }
        public virtual DbSet<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_jianceshenqingdanSet> Zuzhipeixing_linchuanghla_jianceshenqingdanSet { get; set; }
    }

    public class YonghuSet
    {
        public int id { get; set; }
        public string zhanghao { get; set; }
        public string mima { get; set; }
    }

    public class JichuidSet
    {
        public int id { get; set; }
        public string biaoming { get; set; }
        public string lieming { get; set; }
        public string zifenlei { get; set; }
        public string gengxinpinlv { get; set; }
        public DateTime gengxinshijian { get; set; }
        public int jichuid { get; set; }
    }
}