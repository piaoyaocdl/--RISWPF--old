﻿namespace RIS
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

        public virtual DbSet<PAGE.SYST.YonghuSet> YonghuSet { get; set; }
        public virtual DbSet<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_shenqingdanSet> Zuzhipeixing_linchuanghla_shenqingdanSet { get; set; }
        public virtual DbSet<PAGE.ZUZHIPEIXING.LINCHUANGHLA.JIANCESHENQINGDAN.Zuzhipeixing_linchuanghla_yangbenSet> Zuzhipeixing_linchuanghla_yangbenSet { get; set; }
        public virtual DbSet<PAGE.SYST.WenjianshuomingSet> WenjianshuomingSet { get; set; }
        public virtual DbSet<PAGE.SYST.WenjianSet> WenjianSet { get; set; }
    }
}