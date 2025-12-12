namespace FitnessPlaner.Data.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Duration { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Pinned { get; set; } = false;

        public ICollection<FolderPlan>? FolderPlans { get; set; }
        public ICollection<PlanExercise>? PlanExercises { get; set; }
    }
}
