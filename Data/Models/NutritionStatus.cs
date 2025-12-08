namespace FitnessPlaner.Data.Models
{
    public class NutritionStatus
    {
        public string Color { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public double Percentage { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
