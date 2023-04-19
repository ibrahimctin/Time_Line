namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Login
{
    public sealed record LoginCommandResponse
    {
        public VerifiedUserDto VerifiedUserDto { get; set; }
    }
}