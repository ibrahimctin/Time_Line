namespace Time_Line.Domain.Application.Features.Posts.Queries.GetPostCommentsList
{
    public sealed class GetPostCommnetsListQueryResponse
    {
        public ICollection<PostCommentListResponse> postCommentListResponse { get; set; }
    }
}