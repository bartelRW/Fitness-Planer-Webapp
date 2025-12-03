namespace FitnessPlaner.Data.Models
{
    public class NutritionGoal
    {
        public int Id { get; set; }
        public double Calories { get; set; } = 0;
        public double Protein { get; set; } = 0;
        public double Carbohydrates { get; set; } = 0;
        public double Fats { get; set; } = 0;
    }
}
