namespace ExitTask.Domain.Entities.Concrete
{
    using System;

    using ExitTask.Domain.Entities.Abstract;

    public class Comment : Entity<int>
    {
        public string Text { get; set; }

        public int? AuthorId { get; set; }

        public int? TourId { get; set; }

        public DateTime Date { get; set; }

        public virtual User Author { get; set; }

        public virtual Tour Tour { get; set; }
    }
}