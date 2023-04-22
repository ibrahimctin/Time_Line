namespace Time_Line.Domain.Application.Features.Comments.Queries.GetCommentSubCommetsList
{
    public class GetCommentSubCommetsListQueryHandler
        : IQueryHandler<GetCommentSubCommetsListQuery, GetCommentSubCommetsListQueryResponse>
    {
        public Task<GetCommentSubCommetsListQueryResponse> Handle(GetCommentSubCommetsListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
