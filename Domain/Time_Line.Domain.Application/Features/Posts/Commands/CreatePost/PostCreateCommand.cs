namespace Time_Line.Domain.Application.Features.Posts.Commands.CreatePost
{
    public sealed record PostCreateCommand(PostCreateRequest PostCreateRequest):
        ICommand<PostCreateCommandResponse>
    {
    }
}
