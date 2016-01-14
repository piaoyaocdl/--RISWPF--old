namespace HSWRIS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

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
            yonghuSet.Property(yonghu => yonghu.zhanghao).IsRequired().HasMaxLength(50).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_zhanghao_weiyi_yueshu") { IsUnique = true } ));
            yonghuSet.HasMany(y => y.jueses).WithMany(j => j.yonghus);

            //JueseSet
            var jueseSet = modelBuilder.Entity<JueseSet>();
            jueseSet.HasKey(juese => juese.id);
            jueseSet.Property(juese => juese.jueseming).IsRequired();
            jueseSet.Property(juese => juese.shuoming).IsRequired();

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
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.HasMany(z => z.yangbens).WithRequired(y=>y.shenqingdan);

            //Zuzhipeixing_linchuanghla_yangbenSet
            var zuzhipeixing_linchuanghla_yangbenSet = modelBuilder.Entity<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_yangbenSet>();
            zuzhipeixing_linchuanghla_yangbenSet.HasKey(z=>z.id);
            zuzhipeixing_linchuanghla_yangbenSet.HasMany(z => z.weidians).WithRequired(y=>y.yangben);
            zuzhipeixing_linchuanghla_yangbenSet.Property(z => z.xingming).IsRequired();
            zuzhipeixing_linchuanghla_yangbenSet.Property(z => z.yangbenbianhao).IsRequired();
            zuzhipeixing_linchuanghla_yangbenSet.Property(z => z.leixing).IsRequired();

            //Zuzhipeixing_linchuanghla_weidianSet
            var zuzhipeixing_linchuanghla_weidianSet = modelBuilder.Entity<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_weidianSet>();
            zuzhipeixing_linchuanghla_weidianSet.HasKey(z => z.id);
        }
        public virtual DbSet<YonghuSet> YonghuSet { get; set; }
        public virtual DbSet<JueseSet> JueseSet { get; set; }
        public virtual DbSet<JichuidSet> JichuidSet { get; set; }
        public virtual DbSet<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_jianceshenqingdanSet> Zuzhipeixing_linchuanghla_jianceshenqingdanSet { get; set; }
        public virtual DbSet<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_yangbenSet> Zuzhipeixing_linchuanghla_yangbenSet { get; set; }
        public virtual DbSet<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_weidianSet> Zuzhipeixing_linchuanghla_weidianSet { get; set; }
    }

    public class YonghuSet
    {
        public int id { get; set; }
        public string zhanghao { get; set; }
        public string mima { get; set; }

        public virtual ICollection<JueseSet> jueses
        {
            set
            {
                this.jueses_ = value;
            }
            get
            {
                if (this.jueses_==null)
                {
                    this.jueses_ = new List<JueseSet>();
                }
                return this.jueses_;
            }
        }
        //---------------------------------------------------------------
        private ICollection<JueseSet> jueses_;
        public bool xiangtong(YonghuSet y)
        {
            if (this.zhanghao.Equals(y.zhanghao))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class JueseSet
    {
        public int id { get; set; }
        public string jueseming { get; set; }
        public string shuoming { get; set; }
        public virtual ICollection<YonghuSet> yonghus
        {
            set
            {
                this.yonghus_ = value;
            }
            get
            {
                if (this.yonghus_==null)
                {
                    this.yonghus_ = new List<YonghuSet>();
                }
                return this.yonghus_;
            }
        }
        //---------------------------------------------------------------
        private ICollection<YonghuSet> yonghus_;
        public bool xiangtong(JueseSet j)
        {
            if (this.jueseming.Equals(j.jueseming))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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