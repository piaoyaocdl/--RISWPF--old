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
            yonghuSet.Property(yonghu => yonghu.zhanghao).IsRequired().HasMaxLength(50).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_zhanghao_weiyi_yueshu") { IsUnique = true }));
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
            var zuzhipeixing_linchuanghla_jianceshenqingdanSet = modelBuilder.Entity<Zuzhipeixing_linchuanghla_jianceshenqingdanSet>();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.HasKey(z => z.id);
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.Property(z => z.huanzhexingming).IsRequired();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.Property(z => z.shouyangriqi).IsRequired();
            zuzhipeixing_linchuanghla_jianceshenqingdanSet.HasMany(z => z.yangbens).WithRequired(y => y.shenqingdan);

            //Zuzhipeixing_linchuanghla_yangbenSet
            var zuzhipeixing_linchuanghla_yangbenSet = modelBuilder.Entity<Zuzhipeixing_linchuanghla_yangbenSet>();
            zuzhipeixing_linchuanghla_yangbenSet.HasKey(z => z.id);
            zuzhipeixing_linchuanghla_yangbenSet.HasMany(z => z.weidians).WithRequired(y => y.yangben);
            zuzhipeixing_linchuanghla_yangbenSet.Property(z => z.xingming).IsRequired();
            zuzhipeixing_linchuanghla_yangbenSet.Property(z => z.yangbenbianhao).IsRequired();
            zuzhipeixing_linchuanghla_yangbenSet.Property(z => z.leixing).IsRequired();

            //Zuzhipeixing_linchuanghla_weidianSet
            var zuzhipeixing_linchuanghla_weidianSet = modelBuilder.Entity<Zuzhipeixing_linchuanghla_weidianSet>();
            zuzhipeixing_linchuanghla_weidianSet.HasKey(z => z.id);
        }
        public virtual DbSet<YonghuSet> YonghuSet { get; set; }
        public virtual DbSet<JueseSet> JueseSet { get; set; }
        public virtual DbSet<JichuidSet> JichuidSet { get; set; }
        public virtual DbSet<Zuzhipeixing_linchuanghla_jianceshenqingdanSet> Zuzhipeixing_linchuanghla_jianceshenqingdanSet { get; set; }
        public virtual DbSet<Zuzhipeixing_linchuanghla_yangbenSet> Zuzhipeixing_linchuanghla_yangbenSet { get; set; }
        public virtual DbSet<Zuzhipeixing_linchuanghla_weidianSet> Zuzhipeixing_linchuanghla_weidianSet { get; set; }
    }


    //组织配型-临床HLA-位点
    public class Zuzhipeixing_linchuanghla_weidianSet
    {
        public int id { set; get; }

        public string fenzu { set; get; }
        public string leixing { set; get; }
        public string weidian { set; get; }
        public string beizhu { set; get; }

        public Zuzhipeixing_linchuanghla_yangbenSet yangben { set; get; }

        public bool xiangtong(Zuzhipeixing_linchuanghla_weidianSet z)
        {
            if (z.fenzu.Equals(this.fenzu) && z.leixing.Equals(this.leixing) && z.weidian.Equals(this.weidian))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //组织配型-临床HLA-样本
    public class Zuzhipeixing_linchuanghla_yangbenSet
    {

        public int id { set; get; }

        public string yuanshibianhao { set; get; }//原始编号
        public string xingming { set; get; }//姓名
        public string xingbie { set; get; }//性别
        public Nullable<DateTime> chushengriqi { set; get; }//出生日期
        public string leixing { set; get; }//类型
        public string yangbenbianhao { set; get; }//样本编号
        public Nullable<bool> huanzhebenren { set; get; }//患者本人
        public string gonghuanguanxi { set; get; }//共患关系
        public string songjiandanwei { set; get; }//送检单位
        public string yangbenleixing { set; get; }//样本类型
        public Nullable<int> yangguanshu { set; get; }//样管数
        public Nullable<bool> yangbenhege { set; get; }//样本合格
        public Nullable<DateTime> caiyangriqi { set; get; }//采样日期
        public Nullable<DateTime> shouyangriqi { set; get; }//收样日期
        public Nullable<DateTime> fufeiriqi { set; get; }//付费日期
        public string shouyangzhe { set; get; }//收样者
        public Nullable<DateTime> jianceriqi { set; get; }//检测日期
        public string beizhu { set; get; }//备注

        public Zuzhipeixing_linchuanghla_jianceshenqingdanSet shenqingdan { get; set; }
        public virtual ICollection<Zuzhipeixing_linchuanghla_weidianSet> weidians
        {
            set
            {
                this.weidians_ = value;
            }
            get
            {
                if (this.weidians_ == null)
                {
                    this.weidians_ = new List<Zuzhipeixing_linchuanghla_weidianSet>();
                }
                return this.weidians_;
            }
        }
        //-------------------------------------------------------------------------
        private ICollection<Zuzhipeixing_linchuanghla_weidianSet> weidians_;
    }
    //组织配型-临床HLA-检测申请单
    public class Zuzhipeixing_linchuanghla_jianceshenqingdanSet
    {
        public int id { set; get; }
        public string bianhao { set; get; }
        public string huanzhexingming { set; get; }
        public string xingbie { set; get; }
        public string shenfenzhenghao { set; get; }
        public string linchuangzhenduan { set; get; }
        public string chuanghao { set; get; }
        public string shenqingyiyuan { set; get; }
        public string shenqingyisheng { set; get; }
        public string zhuyuanhao { set; get; }
        public string baogaofasongfangshi { set; get; }
        public string lianxidianhua { set; get; }
        public string fax { set; get; }
        public string email { set; get; }
        public string youbian { set; get; }
        public string tongxundizhi { set; get; }
        public string shouyangzhe { set; get; }
        public string beizhu { set; get; }

        public Nullable<DateTime> chushengriqi { set; get; }
        public Nullable<DateTime> caiyangriqi { set; get; }
        public Nullable<DateTime> shouyangriqi { set; get; }
        public Nullable<DateTime> jiancedanriqi { set; get; }
        public Nullable<bool> zhuyuan { set; get; }
        public Nullable<bool> menzhen { set; get; }

        public virtual ICollection<Zuzhipeixing_linchuanghla_yangbenSet> yangbens
        {
            get
            {
                if (this.yangbens_ == null)
                {
                    this.yangbens_ = new List<Zuzhipeixing_linchuanghla_yangbenSet>();
                }
                return this.yangbens_;
            }
            set
            {
                this.yangbens_ = value;
            }
        }
        //----------------------------------------------------
        public ICollection<Zuzhipeixing_linchuanghla_yangbenSet> yangbens_;

    }

    // 用户
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
                if (this.jueses_ == null)
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

    // 角色
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
                if (this.yonghus_ == null)
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
    // 基础ID
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