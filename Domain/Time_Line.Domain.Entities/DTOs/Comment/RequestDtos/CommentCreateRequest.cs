namespace Time_Line.Domain.Entities.DTOs.Comment.RequestDtos
{
    public class CommentCreateRequest
    {
        public string? PostId { get; set; }
        public string ContentBody { get; set; }
    
    }
}
