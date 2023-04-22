namespace Time_Line.Persistence.Repositories.Posts
{
    internal class PostReadRepository : ReadRepository<Post>, IPostReadRepository
    {
        public PostReadRepository(AppDbContext context) : base(context)
        {
        }

        public  async Task<ICollection<Post>> GetPostCommentsAsync(string postId)
        {
            var postResultFrmDb = await GetAll(false)
                 .Include(c => c.Comments)
                 .Where(c => c.Id == postId)
                 .ToListAsync();
            return postResultFrmDb is null 
                ? throw new PostNotFoundException(postId)
                : postResultFrmDb; 
        }
    }
}
