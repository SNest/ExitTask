namespace ExitTask.Domain.Entities.Concrete
{
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class User : Entity<int>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public UserSex Sex { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public UserState State { get; set; }

        public byte[] Avatar { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}