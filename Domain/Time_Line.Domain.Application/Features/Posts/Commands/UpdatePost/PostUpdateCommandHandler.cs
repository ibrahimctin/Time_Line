namespace Time_Line.Domain.Application.Features.Posts.Commands.UpdatePost
{
    public class PostUpdateCommandHandler
        : ICommandHandler<PostUpdateCommand, PostUpdateCommandResponse>
    {
        private readonly IPostService _postService;

        public PostUpdateCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<PostUpdateCommandResponse> Handle(PostUpdateCommand request, CancellationToken cancellationToken)
        {
            var postResult = await _postService.UpdatePostAsync(request);
            return new PostUpdateCommandResponse
            {
                UpdatedPostResult = postResult
            };
        }
    }
}
