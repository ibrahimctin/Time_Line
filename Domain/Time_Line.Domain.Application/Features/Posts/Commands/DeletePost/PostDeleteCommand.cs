namespace Time_Line.Domain.Application.Features.Posts.Commands.DeletePost
{
    public sealed record PostDeleteCommand(string postId)
        :ICommand<PostDeleteCommandResponse>
    {
    }
}
