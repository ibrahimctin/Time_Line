namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public sealed class PostNotFoundException:NotFoundException
    {
        public PostNotFoundException(string postId)
            : base($"The post with the identifier {postId} was not found.")
        {
        }
    }
}
