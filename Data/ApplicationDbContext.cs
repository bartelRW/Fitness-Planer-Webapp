using FitnessPlaner.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    // Define DbSet properties for each entity
    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<Folder> Folders => Set<Folder>();
    public DbSet<FolderPlan> FolderPlans => Set<FolderPlan>();
    public DbSet<Plan> Plans => Set<Plan>();
    public DbSet<PlanExercise> PlanExercises => Set<PlanExercise>();
    public DbSet<NutritionGoal> NutritionGoals => Set<NutritionGoal>();
    public DbSet<FoodEntry> FoodEntries => Set<FoodEntry>();

    // Configure the model
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Map the User entity to the "users" table
        builder.Entity<Exercise>().ToTable("exercises");
        builder.Entity<Folder>().ToTable("folders");
        builder.Entity<FolderPlan>().ToTable("folderplans");
        builder.Entity<Plan>().ToTable("plans");
        builder.Entity<PlanExercise>().ToTable("planexercises");
        builder.Entity<NutritionGoal>().ToTable("nutritiongoal");
        builder.Entity<FoodEntry>().ToTable("foodentries");
    }
}
