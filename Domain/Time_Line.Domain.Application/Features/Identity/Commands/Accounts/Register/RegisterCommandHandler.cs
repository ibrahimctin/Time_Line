using Time_Line.Domain.Application.Abstraction.Identity;

namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Register
{
    public class RegisterCommandHandler
        : ICommandHandler<RegisterCommand, RegisterCommandResponse>
    {
        private readonly IUserService _userService;

        public RegisterCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<RegisterCommandResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var result = await _userService.CreateUserAsync(request.RegisterDto);
            return new RegisterCommandResponse
            {
                IdentityResult = result
            };
        }
    }
}
