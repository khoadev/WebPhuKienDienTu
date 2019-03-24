namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebPhuKienDienTuDbConText : DbContext
    {
        public WebPhuKienDienTuDbConText()
            : base("name=WebPhuKienDienTu")
        {
        }

        public virtual DbSet<s5_comment> s5_comment { get; set; }
        public virtual DbSet<s5_order> s5_order { get; set; }
        public virtual DbSet<s5_order_detail> s5_order_detail { get; set; }
        public virtual DbSet<s5_product> s5_product { get; set; }
        public virtual DbSet<s5_reply> s5_reply { get; set; }
        public virtual DbSet<s5_status> s5_status { get; set; }
        public virtual DbSet<s5_user> s5_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<s5_order_detail>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<s5_product>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<s5_product>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<s5_user>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<s5_user>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
