namespace Time_Line.Domain.Application.Features.Posts.Queries.GetPostCommentsList
{
    public class GetPostCommnetsListQueryHandler
        : IQueryHandler<GetPostCommnetsListQuery, GetPostCommnetsListQueryResponse>
    {
        private readonly IPostService _postService;

        public GetPostCommnetsListQueryHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<GetPostCommnetsListQueryResponse> Handle(GetPostCommnetsListQuery request, CancellationToken cancellationToken)
        {
            var postCommentsResult = await _postService.GetPostCommentsAsync(request.commentId);
            return new GetPostCommnetsListQueryResponse
            { 
                postCommentListResponse = postCommentsResult 
            };
        }
    }
}
