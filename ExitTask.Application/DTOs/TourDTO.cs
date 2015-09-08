namespace ExitTask.Application.DTOs
{
    class TourDto
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
