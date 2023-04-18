namespace Time_Line.Domain.Application.Abstraction.Identity
{
    public interface ICurrentUserService
    {
        string UserId { get; set; }
        Task<AppUser> GetCurrentUser();
        Task<string> GetCurrentUserIdAsync();
    }
}
