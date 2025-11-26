using System.ComponentModel.DataAnnotations;

namespace FitnessPlaner.Data.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name darf nicht leer sein")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "darf nicht kleiner als 0 sein")]
        public int Sets { get; set; }

        [Required(ErrorMessage = "darf nicht kleiner als 0 sein")]
        public int Repetitions { get; set; }
        public string Notes { get; set; } = string.Empty;

        public ICollection<PlanExercise>? PlanExercises { get; set; }
    }
}
