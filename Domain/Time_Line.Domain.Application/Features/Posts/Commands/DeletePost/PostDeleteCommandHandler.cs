namespace Time_Line.Domain.Application.Features.Posts.Commands.DeletePost
{
    public class PostDeleteCommandHandler
        : ICommandHandler<PostDeleteCommand, PostDeleteCommandResponse>
    {
        private readonly IPostService _postService;

        public PostDeleteCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<PostDeleteCommandResponse> Handle(PostDeleteCommand request, CancellationToken cancellationToken)
        {
            var postResult = await _postService.DeletePostAsync(request);
            return new PostDeleteCommandResponse 
            {
                DeletedPostResult = postResult 
            };
        }
    }
}
