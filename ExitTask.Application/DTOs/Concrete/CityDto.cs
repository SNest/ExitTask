namespace ExitTask.Application.DTOs.Concrete
{
    public class CityDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int CountryId { get; set; }

        public  CountryDto Country { get; set; }
    }
}
