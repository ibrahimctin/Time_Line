namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangePassword
{
    public class ChangePasswordCommandHandler
        : ICommandHandler<ChangePasswordCommand, ChangePasswordCommandResponse>
    {
        private readonly IUserService _userService;

        public ChangePasswordCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ChangePasswordCommandResponse> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var result = await _userService.ChangePasswordAsync(request.currPasword, request.newPassword);
            return new ChangePasswordCommandResponse
            {
                PasswordChanged = result
            };
        }
    }
}
