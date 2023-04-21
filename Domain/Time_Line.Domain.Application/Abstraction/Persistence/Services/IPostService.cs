namespace Time_Line.Domain.Application.Abstraction.Persistence.Services
{
    public interface IPostService
    {
        Task<string> CreatePostAsync(PostCreateCommand postCreateCommand);
        Task<PostDetailResponse> GetPostDetailAsync(string postId);
        Task<ICollection<PostCommentListResponse>>GetPostCommentsAsync(string commentId);
        Task<string> UpdatePostAsync(PostUpdateCommand postUpdateCommand);
        Task<bool> DeletePostAsync(PostDeleteCommand postDeleteCommand);
    }
}
