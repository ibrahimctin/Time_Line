namespace Time_Line.Domain.Application.Abstraction.Persistence.Services
{
    public interface ICommentService
    {
        Task<string> CreateCommentAsync(CommentCreateCommand commentCreateCommand);
        Task<string> UpdateCommentAsync(CommentUpdateCommand commentUpdateCommand);
        Task<bool> DeleteCommentAsync(CommentDeleteCommand commentDeleteCommand);
        Task<CommentDetailResponse> GetCommentDetailAsync(string commentId);
        Task<ICollection<CommentSubCommentsListResposne>> GetPostCommentsAsync(string commentId);

    }
}
