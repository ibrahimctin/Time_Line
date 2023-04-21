namespace Time_Line.Domain.Application.Features.Comments.Commands.CreateComment
{
    public sealed record CommentCreateCommand(CommentCreateRequest CommentCreateRequest)
        :ICommand<CommentCreateCommandResponse>
    {
    }
}
