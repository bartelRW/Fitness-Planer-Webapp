using System.ComponentModel.DataAnnotations;

namespace FitnessPlaner.Data.Models
{
    public class FoodEntry
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbohydrates { get; set; }
        public int Fats { get; set; }
    }
}
