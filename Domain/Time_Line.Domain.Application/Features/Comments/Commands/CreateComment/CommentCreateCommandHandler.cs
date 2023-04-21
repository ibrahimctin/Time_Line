namespace Time_Line.Domain.Application.Features.Comments.Commands.CreateComment
{
    public class CommentCreateCommandHandler
        : ICommandHandler<CommentCreateCommand, CommentCreateCommandResponse>
    {
        private readonly ICommentService _commentService;

        public CommentCreateCommandHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<CommentCreateCommandResponse> Handle(CommentCreateCommand request, CancellationToken cancellationToken)
        {
            var commentResult = await _commentService.CreateCommentAsync(request);
            return new CommentCreateCommandResponse
            {
                CreatedCommentResponse = commentResult
            };
        }
    }
}
