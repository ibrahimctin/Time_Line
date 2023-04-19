namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Register
{
    public sealed record RegisterCommandResponse
    {
        public IdentityResult IdentityResult { get; set; }
    }
}
