namespace Time_Line.Persistence.Repositories.Posts
{
    internal class PostReadRepository : ReadRepository<Post>, IPostReadRepository
    {
        public PostReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
