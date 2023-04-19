namespace Time_Line.Domain.Application.Features.Identity.Commands.Accounts.ChangeEmail
{
    public class ChangeEmailCommandHandler :
        ICommandHandler<ChangeEmailCommand, ChangeEmailCommandResponse>
    {
        private readonly IUserService _userService;

        public ChangeEmailCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ChangeEmailCommandResponse> Handle(ChangeEmailCommand request, CancellationToken cancellationToken)
        {
            var result = await _userService.ChangeEmailAsync(request.email, request.password);
            return new ChangeEmailCommandResponse
            {
                EmailChanged = result
            };
        }
    }
}
