namespace Time_Line.Domain.Application.Features.SubComments.Queries.GetSubCommentDetail
{
    public class GetSubCommentDetailQueryHandler
        : IQueryHandler<GetSubCommentDetailQuery, GetSubCommentDetailQueryResponse>
    {
        public Task<GetSubCommentDetailQueryResponse> Handle(GetSubCommentDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
