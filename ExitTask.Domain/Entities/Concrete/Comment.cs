namespace ExitTask.Domain.Entities.Concrete
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    class Comment
    {
        public string Text { get; set; }

        public int AuthorId { get; set; }
        public int TourId { get; set; }

        public DateTime Date { get; set; } 

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        [ForeignKey("TourId")]
        public virtual User Tour { get; set; }
    }
}
