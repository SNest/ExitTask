namespace ExitTask.Domain.Entities.Concrete
{
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class User : Entity<int>
    {
        [Required, DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public UserSex Sex { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [Required]
        public UserState State { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}