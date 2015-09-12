namespace ExitTask.Domain.Entities.Concrete
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enums;

    public class Tour : Entity<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TourType Type { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int NightNumber { get; set; }  

        [Required]
        public decimal Price { get; set; }

        [Required]
        public TourState State { get; set; }

        public int? RouteId { get; set; }

        public virtual Route Route { get; set; }

        public virtual Picture Picture { get; set; }

    }
}