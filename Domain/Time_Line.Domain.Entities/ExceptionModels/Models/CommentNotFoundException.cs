namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public sealed class CommentNotFoundException:NotFoundException
    {
        public CommentNotFoundException(string Id)
           : base($"The comment with the identifier {Id} was not found.")
        {
        }
    }
}
