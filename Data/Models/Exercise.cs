namespace FitnessPlaner.Data.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public string Notes { get; set; } = string.Empty;

        public ICollection<PlanExercise>? PlanExercises { get; set; }
    }
}
