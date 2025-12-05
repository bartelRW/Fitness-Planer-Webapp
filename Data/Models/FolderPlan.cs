namespace FitnessPlaner.Data.Models
{
    public class FolderPlan
    {
        public int Id { get; set; }

        public int FolderId { get; set; }
        public Folder Folder { get; set; } = default!;

        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
    }
}
