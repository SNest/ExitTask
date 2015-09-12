namespace ExitTask.Application.DTOs.Concrete.Tour
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;

    class GetTourPreviewsOutput : IOutputDto
    {
        public List<TourPreviewDto> TourPreviews { get; set; } 
    }
}
