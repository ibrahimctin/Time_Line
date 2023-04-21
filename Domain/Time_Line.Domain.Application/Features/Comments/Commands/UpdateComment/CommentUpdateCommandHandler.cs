namespace Time_Line.Domain.Application.Features.Comments.Commands.UpdateComment
{
    public class CommentUpdateCommandHandler
        : ICommandHandler<CommentUpdateCommand, CommentUpdateCommandResponse>
    {
        private readonly ICommentService _commentService;

        public CommentUpdateCommandHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<CommentUpdateCommandResponse> Handle(CommentUpdateCommand request, CancellationToken cancellationToken)
        {
            var commentResult = await _commentService.UpdateCommentAsync(request);
            return new CommentUpdateCommandResponse
            {
                UpdatedComment = commentResult
            };
        }
    }
}
