namespace Time_Line.Domain.Application.Features.Comments.Queries.GetCommentSubCommetsList
{
    public sealed class GetCommentSubCommetsListQueryResponse
    {
        public ICollection<CommentSubCommentsListResposne> CommentSubCommentsListResposnes { get; set; }
    }
}