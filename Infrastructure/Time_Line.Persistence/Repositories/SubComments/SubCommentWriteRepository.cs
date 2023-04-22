namespace Time_Line.Persistence.Repositories.SubComments
{
    public class SubCommentWriteRepository : WriteRepository<SubComment>, ISubCommentWriteRepository
    {
        public SubCommentWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
