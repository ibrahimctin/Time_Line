namespace Time_Line.Domain.Application.Abstraction.Persistence.Services
{
    public interface ISubCommentService
    {
        Task<string> CreateSubCommentAsync(SubCommentCreateCommand subCommentCreateCommand);
        Task<string> UpdateSubCommentAsync(SubCommentUpdateCommand subCommentUpdateCommand);
        Task<bool> DeleteSubCommentAsync(SubCommentDeleteCommand subCommentDeleteCommand);
        Task<SubCommentDetailResponse> GetSubCommentDetailAsync(string subCommentId);

    }
}
