namespace Time_Line.Domain.Application.Features.Posts.Queries.GetPostCommentsList
{
    public sealed record GetPostCommnetsListQuery(string commentId)
        :IQuery<GetPostCommnetsListQueryResponse>
    {
    }
}
