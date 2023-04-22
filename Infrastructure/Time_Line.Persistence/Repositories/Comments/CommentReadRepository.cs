namespace Time_Line.Persistence.Repositories.Comments
{
    public class CommentReadRepository : ReadRepository<Comment>, ICommentReadRepository
    {
        public CommentReadRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<ICollection<Comment>> GetCommentSubCommentsAsync(string commentId)
        {
            var commentResultFrmDb = await GetAll(false)
            .Include(c => c.SubComments)
                 .Where(c => c.Id == commentId)
                 .ToListAsync();
            return commentResultFrmDb is null
                ? throw new CommentNotFoundException(commentId)
                : commentResultFrmDb;
        }
    }
}
