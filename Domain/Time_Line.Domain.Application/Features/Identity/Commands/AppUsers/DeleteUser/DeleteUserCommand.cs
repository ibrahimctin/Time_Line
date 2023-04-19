namespace Time_Line.Domain.Application.Features.Identity.Commands.AppUsers.DeleteUser
{
    public sealed record DeleteUserCommand(string id)
        : ICommand<DeleteUserCommandResponse>
    {
    }
}