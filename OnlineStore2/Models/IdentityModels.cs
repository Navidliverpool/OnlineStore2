using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OnlineStore2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // DbSet for each of your entity classes
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Motorcycle>()
                .HasMany(m => m.Dealers)
                .WithMany(d => d.Motorcycles)
                .Map(a =>
                {
                    a.ToTable("MotorcycleDealers");
                    a.MapLeftKey("MotorcycleId");
                    a.MapRightKey("DealerId");
                });

            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Categories)
                .WithMany(c => c.Brands)
                .Map(a =>
                {
                    a.ToTable("BrandCategories");
                    a.MapLeftKey("BrandId");
                    a.MapRightKey("CategoryId");
                });

            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Dealers)
                .WithMany(d => d.Brands)
                .Map(a =>
                {
                    a.ToTable("BrandDealers");
                    a.MapLeftKey("BrandId");
                    a.MapRightKey("DealerId");
                });

            modelBuilder.Entity<Motorcycle>()
                .HasRequired(m => m.Brand)
                .WithMany(b => b.Motorcycles)
                .HasForeignKey(m => m.BrandId);

            modelBuilder.Entity<Motorcycle>()
                .HasRequired(m => m.Category)
                .WithMany(c => c.Motorcycles)
                .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<OrderDetail>()
                .HasRequired(o => o.Motorcycle)
                .WithMany(m => m.OrderDetails)
                .HasForeignKey(o => o.MotorcycleId);

            modelBuilder.Entity<OrderDetail>()
                .HasRequired(o => o.Order)
                .WithMany(m => m.OrderDetails)
                .HasForeignKey(o => o.OrderId);

            modelBuilder.Entity<Cart>()
                .HasRequired(c => c.Motorcycle)
                .WithMany(m => m.Carts)
                .HasForeignKey(c => c.MotorcycleId);
        }
    }
}