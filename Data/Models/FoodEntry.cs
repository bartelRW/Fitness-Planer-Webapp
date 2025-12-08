using System.ComponentModel.DataAnnotations;

namespace FitnessPlaner.Data.Models
{
    public class FoodEntry
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
    }
}
