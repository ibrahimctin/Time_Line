namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Register
{
    public sealed record RegisterCommand(RegisterDto RegisterDto) : ICommand<RegisterCommandResponse>
    {
    }
}
