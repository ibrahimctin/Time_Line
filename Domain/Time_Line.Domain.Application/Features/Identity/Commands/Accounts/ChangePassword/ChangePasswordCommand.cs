namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangePassword
{
    public sealed record ChangePasswordCommand(string currPasword,string newPassword)
        :ICommand<ChangePasswordCommandResponse>
    {
    }
}
