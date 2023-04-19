namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Login
{
    public class LoginValidator : AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(l => l.LoginDto.Username)
                .NotEmpty()
                .Length(3, 150);
            RuleFor(l => l.LoginDto.Password)
                .NotEmpty();
        }
    }
}
