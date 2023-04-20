namespace Time_Line.Domain.Application.Features.Posts.Commands.UpdatePost
{
    public sealed record PostUpdateCommand(PostUpdateRequest PostUpdateRequest)
        :ICommand<PostUpdateCommandResponse>
    {
    }
}
