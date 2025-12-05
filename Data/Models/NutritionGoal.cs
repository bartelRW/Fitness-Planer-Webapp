namespace FitnessPlaner.Data.Models
{
    public class NutritionGoal
    {
        public int Id { get; set; }
        public double Calories { get; set; } = 2400;
        public double Protein { get; set; } = 90;
        public double Carbohydrates { get; set; } = 300;
        public double Fats { get; set; } = 93;
    }
}
