namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(string userId)
            : base($"The user with the identifier {userId} was not found.")
        {
        }
    }
}
