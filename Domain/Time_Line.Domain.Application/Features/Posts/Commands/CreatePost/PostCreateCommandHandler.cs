namespace Time_Line.Domain.Application.Features.Posts.Commands.CreatePost
{
    public class PostCreateCommandHandler :
        ICommandHandler<PostCreateCommand, PostCreateCommandResponse>
    {
        private readonly IPostService _postService;

        public PostCreateCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<PostCreateCommandResponse> Handle(PostCreateCommand request, CancellationToken cancellationToken)
        {
            var postResult = await _postService.CreatePostAsync(request);
            return new PostCreateCommandResponse
            {
                CreatedPostResponse = postResult
            };
        }
    }
}
