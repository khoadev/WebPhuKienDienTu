namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhuKienDienTuDbContext : DbContext
    {
        public PhuKienDienTuDbContext()
            : base("name=PhuKienDienTu1")
        {
        }

        public virtual DbSet<s5_comment> s5_comment { get; set; }
        public virtual DbSet<s5_order> s5_order { get; set; }
        public virtual DbSet<s5_order_detail> s5_order_detail { get; set; }
        public virtual DbSet<s5_product> s5_product { get; set; }
        public virtual DbSet<s5_reply> s5_reply { get; set; }
        public virtual DbSet<s5_user> s5_user { get; set; }
        public virtual DbSet<s5_discount> s5_discount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<s5_order>()
                .Property(e => e.mobile)
                .IsUnicode(false);

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
