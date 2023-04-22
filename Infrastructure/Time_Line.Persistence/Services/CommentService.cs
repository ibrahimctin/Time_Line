namespace Time_Line.Persistence.Services
{
    public class CommentService : ICommentService
    {
        private readonly IMapper _mapper;
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly ICurrentUserService _currUserService;
        private readonly IPostReadRepository _postReadRepository;

        public CommentService(
            IMapper mapper,
            ICommentReadRepository commentReadRepository,
            ICommentWriteRepository commentWriteRepository,
            ICurrentUserService currUserService,
            IPostReadRepository postReadRepository)
        {
            _mapper = mapper;
            _commentReadRepository = commentReadRepository;
            _commentWriteRepository = commentWriteRepository;
            _currUserService = currUserService;
            _postReadRepository = postReadRepository;
        }

        #region CRUD Operations 
        public async Task<CommentDetailResponse> GetCommentDetailAsync(string commentId)
        {
            var commentResult = await GetCommentIfCommentExists(commentId);
            var commentPayload = _mapper.Map<CommentDetailResponse>(commentResult);
            return commentPayload;
        }


        public async Task<string> CreateCommentAsync(CommentCreateCommand commentCreateCommand)
        {
            var commentResult = _mapper.Map<Comment>(commentCreateCommand.CommentCreateRequest);
            await GetPostIfPostExists(commentResult.PostId);
            commentResult.User = await GetCurrUserAsync();
            await _commentWriteRepository.AddAsync(commentResult);
            await _commentWriteRepository.SaveAsync();
            return commentResult.Id;


        }


        public async Task<string> UpdateCommentAsync(CommentUpdateCommand commentUpdateCommand)
        {
            var commentResult = await GetCommentIfCommentExists(commentUpdateCommand.CommentUpdateRequest.Id);
            var commentPayload = _mapper.Map(commentUpdateCommand.CommentUpdateRequest, commentResult);

            _commentWriteRepository.Update(commentPayload);
            await _commentWriteRepository.SaveAsync();
            return commentPayload.Id;
        }

        public async Task<bool> DeleteCommentAsync(CommentDeleteCommand commentDeleteCommand)
        {
            var commentResult = await GetCommentIfCommentExists(commentDeleteCommand.commentId);
            var deletedComment = _commentWriteRepository.Remove(commentResult);
            await _commentWriteRepository.SaveAsync();
            if (!deletedComment)
            {
                return false;
            }
            return true;
        }
        #endregion


        #region My Private Methods
        private async Task<AppUser> GetCurrUserAsync() => await _currUserService.GetCurrentUser();
        private async Task<Post> GetPostIfPostExists(string id)
        {
            var result = await _postReadRepository
                .Table
                .Where
                (p => p.Id == id)
                .FirstOrDefaultAsync();


            if (result == null)
                throw new PostNotFoundException(result.Id);

            return result;
        }
        private async Task<Comment> GetCommentIfCommentExists(string id)
        {
            var result = await _commentReadRepository
                .GetWhere(p => p.Id == id)
                .Include(p => p.User)
                .FirstOrDefaultAsync();


            if (result == null)
                throw new CommentNotFoundException(result.Id);

            return result;
        }

       



        #endregion
    }
}
