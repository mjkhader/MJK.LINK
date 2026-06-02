using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DBContext
{
    public class HealthDBContext : IdentityDbContext
    {
        public HealthDBContext(DbContextOptions<HealthDBContext> options)
            : base(options)
        {
        }

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<PatientNutritionist> PatientNutritionists { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<ConditionTable> ConditionTables { get; set; }
        public DbSet<UserCondition> UserConditions { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<MealTag> MealTags { get; set; }
        public DbSet<OrderTable> OrderTables { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionDay> SubscriptionDays { get; set; }
        public DbSet<SubscriptionDayMeal> SubscriptionDayMeals { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DriverLocation> DriverLocations { get; set; }
        public DbSet<DoctorRestaurantDiscount> DoctorRestaurantDiscounts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite Keys
            modelBuilder.Entity<UserCondition>()
                .HasKey(x => new { x.UserId, x.ConditionId });

            modelBuilder.Entity<MealTag>()
                .HasKey(x => new { x.MealId, x.TagId });

            // Table Names
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Nutritionist>().ToTable("nutritionists");
            modelBuilder.Entity<PatientNutritionist>().ToTable("parientNutritionist");
            modelBuilder.Entity<DietPlan>().ToTable("dietPlan");
            modelBuilder.Entity<ConditionTable>().ToTable("ConditionTable");
            modelBuilder.Entity<UserCondition>().ToTable("UserCondition");
            modelBuilder.Entity<Restaurant>().ToTable("restaurants");
            modelBuilder.Entity<Meal>().ToTable("Meal");
            modelBuilder.Entity<Tag>().ToTable("tag");
            modelBuilder.Entity<MealTag>().ToTable("mealTag");
            modelBuilder.Entity<OrderTable>().ToTable("orderTable");
            modelBuilder.Entity<OrderItem>().ToTable("orderItem");
            modelBuilder.Entity<Subscription>().ToTable("subscriptions");
            modelBuilder.Entity<SubscriptionDay>().ToTable("SubscriptionDay");
            modelBuilder.Entity<SubscriptionDayMeal>().ToTable("SubscriptionDayMeal");
            modelBuilder.Entity<Driver>().ToTable("Drivers");
            modelBuilder.Entity<Delivery>().ToTable("deliverys");
            modelBuilder.Entity<DriverLocation>().ToTable("driverLocation");
            modelBuilder.Entity<DoctorRestaurantDiscount>().ToTable("DoctorRestaurantDiscount");
            modelBuilder.Entity<Payment>().ToTable("Payment");

            // Optional: Unique indexes matching database constraints
            modelBuilder.Entity<User>()
                .HasIndex(x => x.UserName)
                .IsUnique();

            modelBuilder.Entity<Nutritionist>()
                .HasIndex(x => x.UserName)
                .IsUnique();

            modelBuilder.Entity<Restaurant>()
                .HasIndex(x => x.UserName)
                .IsUnique();

            modelBuilder.Entity<Driver>()
                .HasIndex(x => x.UserName)
                .IsUnique();

            // Optional filtered unique email index for Drivers
            modelBuilder.Entity<Driver>()
                .HasIndex(x => x.Email)
                .IsUnique()
                .HasFilter("[Email] IS NOT NULL");

            modelBuilder.Entity<Delivery>()
                 .HasOne(d => d.OrderTable)
                 .WithOne(o => o.Delivery)
                 .HasForeignKey<Delivery>(d => d.OrderId);


            modelBuilder.Entity<Delivery>()
                  .HasOne(d => d.Driver)
                  .WithMany(dr => dr.Deliveries)
                  .HasForeignKey(d => d.DriverId);

            modelBuilder.Entity<DriverLocation>()
                .HasOne(dl => dl.Delivery)
                .WithMany(d => d.DriverLocations)
                .HasForeignKey(dl => dl.DeliveryId);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.OrderTable)
                .WithMany(o => o.Payments)
                .HasForeignKey(p => p.OrderId);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.UserName).HasColumnName("user_name");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.MidName).HasColumnName("mid_name");
                entity.Property(e => e.LastName).HasColumnName("last_name");
                entity.Property(e => e.Phone).HasColumnName("phone");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.PasswordHash).HasColumnName("passwordHash");
                entity.Property(e => e.Height).HasColumnName("height");
                entity.Property(e => e.Weight).HasColumnName("weight");
                entity.Property(e => e.Goal).HasColumnName("goal");
                entity.Property(e => e.CreateAt).HasColumnName("create_at");
            });

            modelBuilder.Entity<Nutritionist>(entity =>
            {
                entity.ToTable("nutritionists");

                entity.Property(e => e.UserName).HasColumnName("user_name");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.MidName).HasColumnName("mid_name");
                entity.Property(e => e.LastName).HasColumnName("last_name");
                entity.Property(e => e.CreateAt).HasColumnName("create_at");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("restaurants");

                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.Name)
                      .HasColumnName("name");

                entity.Property(e => e.UserName)
                      .HasColumnName("user_name");

                entity.Property(e => e.Phone)
                      .HasColumnName("phone");

                entity.Property(e => e.AddressText)
                      .HasColumnName("address_text");

                entity.Property(e => e.Lat)
                      .HasColumnName("lat");

                entity.Property(e => e.Lng)
                      .HasColumnName("lng");

                entity.Property(e => e.IsActive)
                      .HasColumnName("IsActive");
            });


        }
    }
}