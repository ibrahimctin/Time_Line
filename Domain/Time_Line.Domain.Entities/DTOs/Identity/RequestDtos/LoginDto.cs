namespace Time_Line.Domain.Entities.DTOs.Identity.RequestDtos
{
    public class LoginDto
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
