namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeUserName
{
    public class ChangeUserNameCommandHandler :
        ICommandHandler<ChangeUserNameCommand, ChangeUserNameCommandResponse>
    {
        private readonly IUserService _userService;

        public ChangeUserNameCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ChangeUserNameCommandResponse> Handle(ChangeUserNameCommand request, CancellationToken cancellationToken)
        {
            var result = await _userService.ChangeUsernameAsync(request.UserName, request.Password);
            return new ChangeUserNameCommandResponse
            {
                UserNameChanged = result
            };
        }
    }
}
