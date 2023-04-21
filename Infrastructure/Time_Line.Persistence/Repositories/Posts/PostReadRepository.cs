namespace Time_Line.Persistence.Repositories.Posts
{
    internal class PostReadRepository : ReadRepository<Post>, IPostReadRepository
    {
        public PostReadRepository(AppDbContext context) : base(context)
        {
        }

        public  async Task<ICollection<Post>> GetPostCommentsAsync(string commentId)
        {
            var postResultFrmDb = await GetAll(false)
                 .Include(c => c.Comments)
                 .Where(c => c.CommentId == commentId)
                 .ToListAsync();
            return postResultFrmDb is null 
                ? throw new CommentNotFoundException(commentId)
                : postResultFrmDb; 
        }
    }
}
