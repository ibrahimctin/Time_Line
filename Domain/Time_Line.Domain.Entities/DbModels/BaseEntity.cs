namespace Time_Line.Domain.Entities.DbModels
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; }
    }
}
