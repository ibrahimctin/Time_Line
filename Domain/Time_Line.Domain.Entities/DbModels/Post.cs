namespace Time_Line.Domain.Entities.DbModels
{
    public class Post:BaseEntity
    {
        public string Title { get; set; }
        public string ContentBody { get; set; }
        public AppUser? AppUser { get; set; }
        public string? UserId { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public string?  CommentId { get; set; }
        public ICollection<SubComment>? SubComments { get; set; }
        public string?  SubCommentId { get; set; }
    }
}
