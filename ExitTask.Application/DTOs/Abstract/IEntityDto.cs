namespace ExitTask.Application.DTOs.Abstract
{
    public interface IEntityDto<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}