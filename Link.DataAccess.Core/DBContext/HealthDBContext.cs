using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.DBContext
{
    public class HealthDBContext : IdentityDbContext
    {

        public HealthDBContext(DbContextOptions<HealthDBContext> options) : base(options)
        {
        }

        #region DbSet
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserCondition>()
                .HasKey(x => new { x.UserId, x.ConditionId });

            modelBuilder.Entity<MealTag>()
                .HasKey(x => new { x.MealId, x.TagId });

            modelBuilder.Entity<OrderTable>()
                .ToTable("orderTable");

            modelBuilder.Entity<User>()
                .ToTable("users");

            modelBuilder.Entity<Nutritionist>()
                .ToTable("nutritionists");

            modelBuilder.Entity<PatientNutritionist>()
                .ToTable("parientNutritionist");

            modelBuilder.Entity<DietPlan>()
                .ToTable("dietPlan");

            modelBuilder.Entity<ConditionTable>()
                .ToTable("ConditionTable");

            modelBuilder.Entity<UserCondition>()
                .ToTable("UserCondition");

            modelBuilder.Entity<Restaurant>()
                .ToTable("restaurants");

            modelBuilder.Entity<Meal>()
                .ToTable("Meal");

            modelBuilder.Entity<Tag>()
                .ToTable("tag");

            modelBuilder.Entity<MealTag>()
                .ToTable("mealTag");

            modelBuilder.Entity<OrderItem>()
                .ToTable("orderItem");

            modelBuilder.Entity<Subscription>()
                .ToTable("subscriptions");

            modelBuilder.Entity<SubscriptionDay>()
                .ToTable("SubscriptionDay");

            modelBuilder.Entity<SubscriptionDayMeal>()
                .ToTable("SubscriptionDayMeal");

            modelBuilder.Entity<Driver>()
                .ToTable("Drivers");

            modelBuilder.Entity<Delivery>()
                .ToTable("deliverys");

            modelBuilder.Entity<DriverLocation>()
                .ToTable("driverLocation");

            modelBuilder.Entity<DoctorRestaurantDiscount>()
                .ToTable("DoctorRestaurantDiscount");

            modelBuilder.Entity<Payment>()
                .ToTable("Payment");
        }

        #endregion

    }
}
