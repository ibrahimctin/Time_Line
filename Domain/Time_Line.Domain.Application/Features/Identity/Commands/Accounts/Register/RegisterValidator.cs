namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Register
{
    public class RegisterValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterValidator()
        {
            RuleFor(p => p.RegisterDto.Username)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);
            RuleFor(p => p.RegisterDto.Email)
                .NotEmpty()
                .EmailAddress();
            RuleFor(p => p.RegisterDto.Password)
                .NotEmpty()
                .MinimumLength(6)
                .MaximumLength(50);
        }
    }
}
