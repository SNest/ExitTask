namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Domain.Entities.Abstract;

    public class Role : Entity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
