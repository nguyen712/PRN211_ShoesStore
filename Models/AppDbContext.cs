using Microsoft.EntityFrameworkCore;
using PRN211_ShoesStore.Models.Entity;
using System.Drawing;
using Image = PRN211_ShoesStore.Models.Entity.Image;
using Size = PRN211_ShoesStore.Models.Entity.Size;

namespace PRN211_ShoesStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Shoes> shoes { get; set; }
        public DbSet<Sale> sale { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> ordersDetail { get; set; }
        public DbSet<ShoesColor> shoesColors { get; set; }
        public DbSet<ShoesImage> shoesImages { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<CategoryShoes> categoryShoes { get; set; }
        public DbSet<SpecificallyShoes> specificallyShoes { get; set; }
        public DbSet<ColorSpecificallyShoes> colorSpecificallyShoes { get; set; }
        public DbSet<SpecificallyShoesSale> specificallyShoesSales { get; set; }
        public DbSet<SpecificallyShoesSize> specificallyShoesSizes { get; set; }
    }
}
