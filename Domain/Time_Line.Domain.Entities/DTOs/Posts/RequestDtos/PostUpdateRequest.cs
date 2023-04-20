namespace Time_Line.Domain.Entities.DTOs.Posts.RequestDtos
{
    public class PostUpdateRequest
    {
        public string postId { get; set; }
        public string Title { get; set; }
        public string ContentBody { get; set; }
    }
}
