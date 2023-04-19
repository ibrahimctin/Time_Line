namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeEmail
{
    public sealed record ChangeEmailCommand(string email,string password)
        :ICommand<ChangeEmailCommandResponse>
    {
    }
}
