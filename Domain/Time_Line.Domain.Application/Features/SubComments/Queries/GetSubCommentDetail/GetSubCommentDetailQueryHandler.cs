namespace Time_Line.Domain.Application.Features.SubComments.Queries.GetSubCommentDetail
{
    public class GetSubCommentDetailQueryHandler
        : IQueryHandler<GetSubCommentDetailQuery, GetSubCommentDetailQueryResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public GetSubCommentDetailQueryHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<GetSubCommentDetailQueryResponse> Handle(GetSubCommentDetailQuery request, CancellationToken cancellationToken)
        {
            var subCommentResult = await _subCommentService.GetSubCommentDetailAsync(request.id);
            return new GetSubCommentDetailQueryResponse
            {
                SubCommentDetailResponse = subCommentResult
            };
        }
    }
}
