namespace Time_Line.Persistence.Repositories.SubComments
{
    public class SubCommentReadRepository : ReadRepository<SubComment>, ISubCommentReadRepository
    {
        public SubCommentReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
