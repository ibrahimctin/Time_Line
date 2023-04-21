namespace Time_Line.Domain.Application.Abstraction.Persistence.Repositories.Posts
{
    public interface IPostReadRepository:IReadRepository<Post>
    {
        Task<ICollection<Post>> GetPostCommentsAsync(string commentId);
    }
}
