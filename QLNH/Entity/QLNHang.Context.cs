﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNH.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBL3_QLNHEntities : DbContext
    {
        public PBL3_QLNHEntities()
            : base("name=PBL3_QLNHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BanAn> BanAns { get; set; }
        public virtual DbSet<BanSuDung> BanSuDungs { get; set; }
        public virtual DbSet<Ca> Cas { get; set; }
        public virtual DbSet<Danhmucthucan> Danhmucthucans { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonchitiet> HoaDonchitiets { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Thucan> Thucans { get; set; }
    }
}
