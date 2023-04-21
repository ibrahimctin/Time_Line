namespace Time_Line.Persistence.Services
{
    public class PostService : IPostService
    {
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currUserService;
        private readonly IPostReadRepository _postReadRepository;
        private readonly IPostWriteRepository _postWriteRepository;
      


        public PostService(
            IMapper mapper,
            ICurrentUserService currUserService,
            IPostReadRepository postReadRepository,
            IPostWriteRepository postWriteRepository
           )
        {
            _mapper = mapper;
            _currUserService = currUserService;
            _postReadRepository = postReadRepository;
            _postWriteRepository = postWriteRepository;

        }



        #region CRUD Operations 
        public async Task<string> CreatePostAsync(PostCreateCommand postCreateCommand)
        {
            var result = _mapper.Map<Post>(postCreateCommand.PostCreateRequest);
            result.AppUser = await GetCurrUserAsync();
            if (result.AppUser is null)
            {
                throw new UserNotFoundException(result.UserId);
            }
            await _postWriteRepository.AddAsync(result);
            await _postWriteRepository.SaveAsync();
            return result.Id;
        }

        public async Task<PostDetailResponse> GetPostDetailAsync(string postId)
        {
            var postResult = await GetPostIfPostExists(postId);
            var postPayload = _mapper.Map<PostDetailResponse>(postResult);
            return postPayload;

        }
        public async Task<string> UpdatePostAsync(PostUpdateCommand postUpdateCommand)
        {
            var postResult = await GetPostIfPostExists(postUpdateCommand.PostUpdateRequest.postId);
            var postPayload = _mapper.Map(postUpdateCommand.PostUpdateRequest, postResult);

            _postWriteRepository.Update(postPayload);
            await _postWriteRepository.SaveAsync();
            return postPayload.Id;

        }

        public async Task<bool> DeletePostAsync(PostDeleteCommand postDeleteCommand)
        {
            var postResult = await GetPostIfPostExists(postDeleteCommand.postId);
            var deletedPost = _postWriteRepository.Remove(postResult);
            await _postWriteRepository.SaveAsync();
            if (!deletedPost)
            {
                return false;
            }
            return true;
        }
        #endregion

        public async Task<ICollection<PostCommentListResponse>> GetPostCommentsAsync(string commentId)
        {
            var postCommentsResult = await _postReadRepository.GetPostCommentsAsync(commentId);
            var postCommentsPayload = _mapper.Map<ICollection<PostCommentListResponse>>(postCommentsResult);
            return postCommentsPayload;
        }


        #region Private Methods
        private async Task<AppUser> GetCurrUserAsync() => await _currUserService.GetCurrentUser();
        private async Task<Post> GetPostIfPostExists(string id)
        {
            var result = await _postReadRepository
                .GetWhere(p => p.Id == id)
                .Include(p=>p.AppUser)
                .FirstOrDefaultAsync();
                

            if (result == null)
                throw new PostNotFoundException(result.Id);

            return result;
        }

  


        #endregion
    }
}
