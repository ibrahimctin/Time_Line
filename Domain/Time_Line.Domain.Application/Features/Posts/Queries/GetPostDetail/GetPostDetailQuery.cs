namespace Time_Line.Domain.Application.Features.Posts.Queries.GetPostDetail
{
    public sealed record GetPostDetailQuery(string postId)
        : ICommand<GetPostDetailQueryResponse>
    {
    }
}
