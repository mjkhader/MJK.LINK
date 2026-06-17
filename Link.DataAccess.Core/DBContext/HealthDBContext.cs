using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Link.DataAccess.DBContext
{
    public class HealthDbContext
         : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public HealthDbContext(
            DbContextOptions<HealthDbContext> options)
            : base(options)
        {
        }

        #region DbSets

        public DbSet<User> Users { get; set; }

        public DbSet<Nutritionist> Nutritionists { get; set; }

        public DbSet<PatientNutritionist> PatientNutritionists { get; set; }

        public DbSet<DietPlan> DietPlans { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<UserCondition> UserConditions { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<MealTag> MealTags { get; set; }

        public DbSet<Order> Orders { get; set; }

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //----------------------------------------------------
            // Identity Tables
            //----------------------------------------------------

            builder.Entity<ApplicationUser>()
                .ToTable("AspNetUsers");

            builder.Entity<ApplicationRole>()
                .ToTable("AspNetRoles");

            builder.Entity<IdentityUserRole<string>>()
                .ToTable("AspNetUserRoles");

            builder.Entity<IdentityUserClaim<string>>()
                .ToTable("AspNetUserClaims");

            builder.Entity<IdentityUserLogin<string>>()
                .ToTable("AspNetUserLogins");

            builder.Entity<IdentityRoleClaim<string>>()
                .ToTable("AspNetRoleClaims");

            builder.Entity<IdentityUserToken<string>>()
                .ToTable("AspNetUserTokens");

            //----------------------------------------------------
            // Users
            //----------------------------------------------------

            builder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasKey(x => x.Id);

                entity.HasIndex(x => x.AspNetUserId)
                      .IsUnique();

                entity.HasIndex(x => x.UserName)
                      .IsUnique();

                entity.Property(x => x.UserName)
                      .HasMaxLength(50)
                      .IsRequired();

                entity.Property(x => x.Phone)
                      .HasMaxLength(50)
                      .IsRequired();

                entity.Property(x => x.Email)
                      .HasMaxLength(50)
                      .IsRequired();

                entity.HasOne<ApplicationUser>()
                      .WithOne()
                      .HasForeignKey<User>(x => x.AspNetUserId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            //----------------------------------------------------
            // Nutritionists
            //----------------------------------------------------

            builder.Entity<Nutritionist>(entity =>
            {
                entity.ToTable("Nutritionist");

                entity.HasIndex(x => x.AspNetUserId).IsUnique();
                entity.HasIndex(x => x.UserName).IsUnique();
                entity.HasIndex(x => x.Email).IsUnique();

                entity.Property(x => x.Rating)
                    .HasPrecision(3, 2);

                entity.HasOne<ApplicationUser>()
                    .WithOne()
                    .HasForeignKey<Nutritionist>(x => x.AspNetUserId);
            });

            //----------------------------------------------------
            // PatientNutritionist
            //----------------------------------------------------

            builder.Entity<PatientNutritionist>(entity =>
            {
                entity.ToTable("PatientNutritionist");

                entity.HasOne(x => x.User)
                    .WithMany(x => x.PatientNutritionists)
                    .HasForeignKey(x => x.UserId);

                entity.HasOne(x => x.Nutritionist)
                    .WithMany(x => x.PatientNutritionists)
                    .HasForeignKey(x => x.NutritionistId);
            });

            //----------------------------------------------------
            // DietPlan
            //----------------------------------------------------

            builder.Entity<DietPlan>(entity =>
            {
                entity.ToTable("DietPlan");

                entity.HasOne(x => x.User)
                    .WithMany(x => x.DietPlans)
                    .HasForeignKey(x => x.UserId);

                entity.HasOne(x => x.Nutritionist)
                    .WithMany(x => x.DietPlans)
                    .HasForeignKey(x => x.NutritionistId);
            });

            //----------------------------------------------------
            // Conditions
            //----------------------------------------------------

            builder.Entity<Condition>()
                .ToTable("Condition")
                .HasKey(x => x.ConditionId);

            builder.Entity<UserCondition>(entity =>
            {
                entity.ToTable("UserCondition");

                entity.HasKey(x => new
                {
                    x.UserId,
                    x.ConditionId
                });

                entity.HasOne(x => x.User)
                    .WithMany(x => x.UserConditions)
                    .HasForeignKey(x => x.UserId);

                entity.HasOne(x => x.Condition)
                    .WithMany(x => x.UserConditions)
                    .HasForeignKey(x => x.ConditionId);
            });

            //----------------------------------------------------
            // Restaurants
            //----------------------------------------------------

            builder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant");

                entity.HasIndex(x => x.AspNetUserId)
                    .IsUnique();

                entity.HasIndex(x => x.UserName)
                    .IsUnique();

                entity.HasOne<ApplicationUser>()
                    .WithOne()
                    .HasForeignKey<Restaurant>(x => x.AspNetUserId);
            });

            //----------------------------------------------------
            // Meals
            //----------------------------------------------------

            builder.Entity<Meal>(entity =>
            {
                entity.ToTable("Meal");

                entity.HasOne(x => x.Restaurant)
                    .WithMany(x => x.Meals)
                    .HasForeignKey(x => x.RestaurantId);
            });

            //----------------------------------------------------
            // Tags
            //----------------------------------------------------

            builder.Entity<Tag>()
                .ToTable("Tag");

            builder.Entity<MealTag>(entity =>
            {
                entity.ToTable("MealTag");

                entity.HasKey(x => new
                {
                    x.MealId,
                    x.TagId
                });

                entity.HasOne(x => x.Meal)
                    .WithMany(x => x.MealTags)
                    .HasForeignKey(x => x.MealId);

                entity.HasOne(x => x.Tag)
                    .WithMany(x => x.MealTags)
                    .HasForeignKey(x => x.TagId);
            });

            //----------------------------------------------------
            // Orders
            //----------------------------------------------------

            builder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasOne(x => x.User)
                    .WithMany(x => x.Orders)
                    .HasForeignKey(x => x.UserId);

                entity.HasOne(x => x.Restaurant)
                    .WithMany(x => x.Orders)
                    .HasForeignKey(x => x.RestaurantId);
            });

            builder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("orderItem");

                entity.HasOne(x => x.Order)
                    .WithMany(x => x.OrderItems)
                    .HasForeignKey(x => x.OrderId);

                entity.HasOne(x => x.Meal)
                    .WithMany(x => x.OrderItems)
                    .HasForeignKey(x => x.MealId);
            });

            //----------------------------------------------------
            // Subscriptions
            //----------------------------------------------------

            builder.Entity<Subscription>()
                .ToTable("Subscription");

            builder.Entity<SubscriptionDay>()
                .ToTable("SubscriptionDay");

            builder.Entity<SubscriptionDayMeal>(entity =>
            {
                entity.ToTable("SubscriptionDayMeal");

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.SubscriptionDay)
                    .WithMany(x => x.SubscriptionDayMeals)
                    .HasForeignKey(x => x.SubDayId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SubscriptionDayMeal_SubscriptionDay");

                entity.HasOne(x => x.Meal)
                    .WithMany(x => x.SubscriptionDayMeals)
                    .HasForeignKey(x => x.MealId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SubscriptionDayMeal_Meal");
            });

            //----------------------------------------------------
            // Drivers
            //----------------------------------------------------

            builder.Entity<Driver>(entity =>
            {
                entity.ToTable("Driver");

                entity.HasIndex(x => x.AspNetUserId)
                    .IsUnique();

                entity.HasIndex(x => x.UserName)
                    .IsUnique();

                entity.HasIndex(x => x.Email)
                    .IsUnique();

                entity.HasOne<ApplicationUser>()
                    .WithOne()
                    .HasForeignKey<Driver>(x => x.AspNetUserId);

      
                
            });

            //----------------------------------------------------
            // Deliveries
            //----------------------------------------------------

            builder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.HasIndex(x => x.OrderId)
                    .IsUnique();

            });

            builder.Entity<DriverLocation>(entity => 
            {
                entity.ToTable("DriverLocation");
                
            });

            //----------------------------------------------------
            // DoctorRestaurantDiscount
            //----------------------------------------------------

            builder.Entity<DoctorRestaurantDiscount>()
                .ToTable("DoctorRestaurantDiscount");

            //----------------------------------------------------
            // Payment
            //----------------------------------------------------

            builder.Entity<Payment>()
                .ToTable("Payment");
        }
    }
}