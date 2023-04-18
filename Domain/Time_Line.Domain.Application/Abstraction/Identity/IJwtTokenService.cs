namespace Time_Line.Domain.Application.Abstraction.Identity
{
    public interface IJwtTokenService
    {
        string GenerateJsonWebToken(AppUser user, IList<string> roles);
    }
}