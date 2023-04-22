namespace Time_Line.Domain.Application.Features.Comments.Queries.GetCommentSubCommetsList
{
    public sealed record GetCommentSubCommetsListQuery(string id)
        :IQuery<GetCommentSubCommetsListQueryResponse>
    {
    }
}
