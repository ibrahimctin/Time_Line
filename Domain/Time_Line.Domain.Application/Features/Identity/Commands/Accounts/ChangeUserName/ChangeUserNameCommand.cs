namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeUsername
{
    public sealed record ChangeUserNameCommand(string UserName,string Password):
        ICommand<ChangeUserNameCommandResponse>
    {
    }
}
