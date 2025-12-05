namespace FitnessPlaner.Data.Models
{
    public class PlanExercise
    {
        public int Id { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;

        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = default!;
    }
}
