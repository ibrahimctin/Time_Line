namespace Time_Line.Persistence.Repositories.Posts
{
    public class PostWriteRepository : WriteRepository<Post>, IPostWriteRepository
    {
        public PostWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
