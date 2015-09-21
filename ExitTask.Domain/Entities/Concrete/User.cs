namespace ExitTask.Domain.Entities.Concrete
{
    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class User : Entity<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserSex Sex { get; set; }

        public UserRole Role { get; set; }

        public UserState State { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}