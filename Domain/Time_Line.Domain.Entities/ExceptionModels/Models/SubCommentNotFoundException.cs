namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public sealed class SubCommentNotFoundException : NotFoundException
    {
        public SubCommentNotFoundException(string Id)
           : base($"The subcomment with the identifier {Id} was not found.")
        {
        }
    }
}
