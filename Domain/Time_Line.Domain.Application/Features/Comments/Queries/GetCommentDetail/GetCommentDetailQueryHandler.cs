namespace Time_Line.Domain.Application.Features.Comments.Queries.GetCommentDetail
{
    public class GetCommentDetailQueryHandler
        : IQueryHandler<GetCommentDetailQuery, GetCommentDetailQueryResponse>
    {
        private readonly ICommentService _commentService;

        public GetCommentDetailQueryHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<GetCommentDetailQueryResponse> Handle(GetCommentDetailQuery request, CancellationToken cancellationToken)
        {
            var commentResult = await _commentService.GetCommentDetailAsync(request.id);
            return new GetCommentDetailQueryResponse
            {
                CommentDetailResponse = commentResult
            };
        }
    }
}
