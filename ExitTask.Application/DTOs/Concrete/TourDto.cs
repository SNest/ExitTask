namespace ExitTask.Application.DTOs.Concrete
{
    using ExitTask.Application.DTOs.Abstract;

    public class TourDto : IOutputDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

    }
}
