namespace ExitTask.Domain.Entities.Concrete
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enums;

    public class Picture : Entity<int>
    {
        [Key, ForeignKey("Tour")]
        public override int Id { get; set; }
        public int FileId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int PersonId { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
