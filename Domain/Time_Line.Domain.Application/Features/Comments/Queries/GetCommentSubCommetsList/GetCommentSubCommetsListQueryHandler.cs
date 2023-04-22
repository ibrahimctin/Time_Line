namespace Time_Line.Domain.Application.Features.Comments.Queries.GetCommentSubCommetsList
{
    public class GetCommentSubCommetsListQueryHandler
        : IQueryHandler<GetCommentSubCommetsListQuery, GetCommentSubCommetsListQueryResponse>
    {
        private readonly ICommentService _commentService;

        public GetCommentSubCommetsListQueryHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<GetCommentSubCommetsListQueryResponse> Handle(GetCommentSubCommetsListQuery request, CancellationToken cancellationToken)
        {
            var commentSubCommentResult = await _commentService.GetCommentSubCommentsAsync(request.id);
            return new GetCommentSubCommetsListQueryResponse
            {
                CommentSubCommentsListResposnes = commentSubCommentResult
            };
        }
    }
}
