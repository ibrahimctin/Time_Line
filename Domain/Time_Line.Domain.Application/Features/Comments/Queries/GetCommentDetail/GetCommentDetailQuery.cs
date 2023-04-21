namespace Time_Line.Domain.Application.Features.Comments.Queries.GetCommentDetail
{
    public sealed record GetCommentDetailQuery(string id)
        :IQuery<GetCommentDetailQueryResponse>
    {
    }
}
