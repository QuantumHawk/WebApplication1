namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Companies>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Companies>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Companies>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<Companies>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Companies)
                .HasForeignKey(e => e.FK_Companies_Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Commission)
                .HasPrecision(5, 3);

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(15, 2);
        }
    }
}
