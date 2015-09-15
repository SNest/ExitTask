namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;

    public class Role
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
