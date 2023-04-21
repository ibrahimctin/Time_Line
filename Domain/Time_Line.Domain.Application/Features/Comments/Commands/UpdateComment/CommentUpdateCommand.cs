namespace Time_Line.Domain.Application.Features.Comments.Commands.UpdateComment
{
    public sealed record CommentUpdateCommand(CommentUpdateRequest CommentUpdateRequest)
        :ICommand<CommentUpdateCommandResponse>
    {
    }
}
