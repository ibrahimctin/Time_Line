namespace Time_Line.Domain.Entities.DbModels
{
    public class Post:BaseEntity
    {
        public string Title { get; set; }
        public string ContentBody { get; set; }
        public AppUser? AppUser { get; set; }
        public string UserId { get; set; }
    }
}
