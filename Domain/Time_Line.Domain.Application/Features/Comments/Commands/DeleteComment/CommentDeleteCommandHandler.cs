namespace Time_Line.Domain.Application.Features.Comments.Commands.DeleteComment
{
    public class CommentDeleteCommandHandler
        : ICommandHandler<CommentDeleteCommand, CommentDeleteCommandResponse>
    {
        private readonly ICommentService _commentService;

        public CommentDeleteCommandHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<CommentDeleteCommandResponse> Handle(CommentDeleteCommand request, CancellationToken cancellationToken)
        {
            var commentResult = await _commentService.DeleteCommentAsync(request);
            return new CommentDeleteCommandResponse
            {
                DeletedComment = commentResult
            };
        }
    }
}
