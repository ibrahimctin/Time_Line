namespace Time_Line.Domain.Entities.DbModels
{
    public class Comment:BaseEntity
    {
       
        public string ContentBody  { get; set; }
        public string? PostId { get; set; }
        public Post? Post { get; set; }
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
