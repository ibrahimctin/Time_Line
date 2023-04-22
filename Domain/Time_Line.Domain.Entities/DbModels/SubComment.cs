namespace Time_Line.Domain.Entities.DbModels
{
    public class SubComment:BaseEntity
    {
        public string ContentBody { get; set; }
        public Comment? Comment { get; set; }
        public string?  CommentId { get; set; }
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
