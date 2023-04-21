namespace Time_Line.Domain.Application.Features.Comments.Commands.DeleteComment
{
    public sealed record CommentDeleteCommand(string commentId)
        :ICommand<CommentDeleteCommandResponse>
    {
    }
}
