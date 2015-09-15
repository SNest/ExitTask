namespace ExitTask.Domain.Entities.Concrete
{
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;

    public class User : Entity<int>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Sex { get; set; }

        public byte[] Avatar { get; set; }

        public int? RoleId { get; set; }

        public bool IsBlocked { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }

        public virtual Role Role { get; set; }
    }
}