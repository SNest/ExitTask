namespace ExitTask.Domain.Entities.Concrete
{
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enums;

    public class Tour : AuditableEntity<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TourType Type { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual Route Route { get; set; }
    }
}