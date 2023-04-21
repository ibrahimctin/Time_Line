namespace Time_Line.Domain.Entities.DTOs.Posts.ResponseDtos
{
    public class PostCommentListResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ContentBody { get; set; }
        public ICollection<CommentDetailResponse>  CommentDetailResponse { get; set; }
    }
}

