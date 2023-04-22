namespace Time_Line.Domain.Application.Abstraction.Persistence.Repositories.Comments
{
    public interface ICommentReadRepository:IReadRepository<Comment>
    {
        Task<ICollection<Comment>> GetCommentSubCommentsAsync(string commentId);
    }
}
