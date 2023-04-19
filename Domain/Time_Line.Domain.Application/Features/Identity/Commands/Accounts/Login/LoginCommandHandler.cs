namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.Login
{
    public class LoginCommandHandler
        : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IUserService _userService;

        public LoginCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var result = await _userService.LoginUserAsync(request.LoginDto, request.IpAdress);
            return new LoginCommandResponse
            {
                VerifiedUserDto = result
            };
        }

    }
}
