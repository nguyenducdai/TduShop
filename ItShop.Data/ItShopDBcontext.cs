using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using ItShop.Models.Models;

namespace ItShop.Data
{
    public partial class ItShopDBcontext:DbContext
    {

        //public ItShopDBcontext() : base("DefaultConnection")
        //{
        //    // khi load bang cha thi khong load them bang con
        //    this.Configuration.LazyLoadingEnabled = false;

        //}

        public ItShopDBcontext() : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }


        //khai bao danh sach cac bang du lieu

        public DbSet<Footer> Footers { set; get; }

        public DbSet<Menu> Menus { set; get; }

        public DbSet<MenuGroup> MenuGroups { set; get; }

        public DbSet<Order> Orders { set; get; }

        public DbSet<OrderDetail> OrderDetails { set; get; }

        public DbSet<Page> Pages { set; get; }

        public DbSet<Post> Posts { set; get; }

        public DbSet<PostCategory> PostCategorys { set; get; }

        public DbSet<PostTag> PostTags { set; get; }

        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategorys { set; get; }

        public DbSet<ProductTag> ProductTags { set; get; }

        public DbSet<Slide> Slides { set; get; }

        public DbSet<SupportOnline> SupportOnlines { set; get; }

        public DbSet<SystemConfig> SystemConfig { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        public DbSet<Error> Errors { set; get; }

        //ghi de phuong thuc onModelCreating khoi tao khi chay DbContext
        protected override void OnModelCreating(DbModelBuilder Builder)
        {

        }

    }
}
