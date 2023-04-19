namespace Time_Line.Domain.Application.Features.Identity.Commands.AppUsers.DeleteUser
{
    public sealed class DeleteUserCommandHandler :
        ICommandHandler<DeleteUserCommand, DeleteUserCommandResponse>
    {
        private readonly IUserService _userService;

        public DeleteUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _userService.DeleteUserAsync(request.id);
            return new DeleteUserCommandResponse
            {
                IdentityResult = result
            };
        }
    }
}
