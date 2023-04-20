namespace Time_Line.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IRefreshTokenService _refreshTokenService;

        public AccountsController(
            IMediator mediator
            , IRefreshTokenService refreshTokenService = null)
        {
            _mediator = mediator;
            _refreshTokenService = refreshTokenService;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<ActionResult<RegisterCommandResponse>> Create([FromBody] RegisterCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<LoginCommandResponse>> Login([FromBody] LoginDto loginRequest)
        {
            LoginCommand request = new(loginRequest, GetIpAddress());

            var response = await _mediator.Send(request);
            AttachAuthCookies(response.VerifiedUserDto);
            return Ok(response);

        }
        [HttpDelete("[action]")]
        public async Task<ActionResult<DeleteUserCommandResponse>> DeleteUser([FromBody] DeleteUserCommand request)
        {
            var response = await _mediator.Send(request.id);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<ChangeUserNameCommandResponse>> ChangeUserName(string userName,string password)
        {
            ChangeUserNameCommand request = new(userName, password);
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<ChangePasswordCommandResponse>> ChangePassword( string currPassword, string newPassword)
        {
            ChangePasswordCommand request = new(currPassword, newPassword);
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<ChangeEmailCommandResponse>> ChangeEmail( string userName, string password)
        {
            ChangeEmailCommand request = new(userName, password);
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Logout()
        {
            var refreshToken = Request.Cookies[CookieNames.REFRESH_TOKEN];

            if (refreshToken is not null)
                await _refreshTokenService.RevokeToken(refreshToken!, GetIpAddress());

            Response.Cookies.Delete(CookieNames.REFRESH_TOKEN);
            Response.Cookies.Delete(CookieNames.ACCESS_TOKEN);

            return Ok();
        }
        [HttpPost("[action]")]

        public async Task<IActionResult> RevokeToken([FromBody] string bodyToken)
        {
            var token = bodyToken ?? Request.Cookies[CookieNames.REFRESH_TOKEN];

            await _refreshTokenService.RevokeToken(token!, GetIpAddress());

            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshToken()
        {
            var refreshToken = Request.Cookies[CookieNames.REFRESH_TOKEN];
            var data = await _refreshTokenService.RefreshToken(refreshToken!, GetIpAddress());

            var result = new VerifiedUserDto
            {
                AccessTokenExpiration = data.AccessTokenExpiration,
                Email = data.Email,
                RefreshTokenExpiration = data.RefreshTokenExpiration,
                RefreshToken = data.RefreshToken,
                Roles = data.Roles,
                Token=data.Token,
                Username=data.Username
            };

            if (result is not null && !string.IsNullOrEmpty(result?.RefreshToken))
            {
                AttachAuthCookies(result);
            }

            return Ok(result);
        }
        private string GetIpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request?.Headers["X-Forwarded-For"] ?? "localhost";
            else
                return HttpContext.Connection?.RemoteIpAddress?.MapToIPv4().ToString() ?? "localhost";
        }
        private void AttachAuthCookies(VerifiedUserDto user)
        {
            if (user is null) return;

            var refreshTokenOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = user.RefreshTokenExpiration
            };

            var jwtTokenOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = user.AccessTokenExpiration,
            };

            Response.Cookies.Append(CookieNames.REFRESH_TOKEN, user.RefreshToken!, refreshTokenOptions);
            Response.Cookies.Append(CookieNames.ACCESS_TOKEN, user.Token!, jwtTokenOptions);
        }



    }
}
