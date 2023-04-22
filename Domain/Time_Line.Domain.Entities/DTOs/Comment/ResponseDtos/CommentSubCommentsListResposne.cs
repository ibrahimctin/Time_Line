namespace Time_Line.Domain.Entities.DTOs.Comment.ResponseDtos
{
    public class CommentSubCommentsListResposne
    {
        public string Id { get; set; }
        public string ContentBody { get; set; }
        public ICollection<SubCommentDetailResponse> SubCommentDetailResponse { get; set; }
    }
}
