namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Login
{
    public sealed record LoginCommand(LoginDto LoginDto, string IpAdress)
        : ICommand<LoginCommandResponse>
    {
    }
}
