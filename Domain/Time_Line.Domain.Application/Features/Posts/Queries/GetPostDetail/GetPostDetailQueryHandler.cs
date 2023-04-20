namespace Time_Line.Domain.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQueryHandler :
        ICommandHandler<GetPostDetailQuery, GetPostDetailQueryResponse>
    {
        private readonly IPostService _postService;

        public GetPostDetailQueryHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<GetPostDetailQueryResponse> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var postResult = await _postService.GetPostDetailAsync(request.postId);
            return new GetPostDetailQueryResponse
            {
                postDetailResponse = postResult
            };
        }
    }
}
