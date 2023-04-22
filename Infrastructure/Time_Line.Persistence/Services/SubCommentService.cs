namespace Time_Line.Persistence.Services
{
    public class SubCommentService : ISubCommentService
    {
        private readonly IMapper _mapper;
        private readonly ISubCommentReadRepository _subCommentReadRepository;
        private readonly ISubCommentWriteRepository _subCommentWriteRepository;
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly ICurrentUserService _currUserService;

        public SubCommentService(
            IMapper mapper,
            ISubCommentReadRepository subCommentReadRepository,
            ISubCommentWriteRepository subCommentWriteRepository,
            ICommentReadRepository commentReadRepository,
            ICurrentUserService currUserService)
        {
            _mapper = mapper;
            _subCommentReadRepository = subCommentReadRepository;
            _subCommentWriteRepository = subCommentWriteRepository;
            _commentReadRepository = commentReadRepository;
            _currUserService = currUserService;
        }
        #region CRUD Operations 
        public async Task<SubCommentDetailResponse> GetSubCommentDetailAsync(string subCommentId)
        {
            var subCommentResult = await GetSubCommentIfSubCommentExists(subCommentId);
            var subCommentPayload = _mapper.Map<SubCommentDetailResponse>(subCommentResult);
            return subCommentPayload;
        }
        public async Task<string> CreateSubCommentAsync(SubCommentCreateCommand subCommentCreateCommand)
        {
            var subCommentResult = _mapper.Map<SubComment>(subCommentCreateCommand.SubCommentCreateRequest);
            await GetCommentIfCommentExists(subCommentResult.CommentId);
            subCommentResult.User = await GetCurrUserAsync();
            await _subCommentWriteRepository.AddAsync(subCommentResult);
            await _subCommentWriteRepository.SaveAsync();
            return subCommentResult.Id;
        }
        public async Task<string> UpdateSubCommentAsync(SubCommentUpdateCommand subCommentUpdateCommand)
        {
            var subCommentResult = await GetSubCommentIfSubCommentExists(subCommentUpdateCommand.SubCommentUpdateRequest.Id);
            var subCommentPayload = _mapper.Map(subCommentUpdateCommand.SubCommentUpdateRequest, subCommentResult);

            _subCommentWriteRepository.Update(subCommentPayload);
            await _subCommentWriteRepository.SaveAsync();
            return subCommentPayload.Id;
        }

        public async Task<bool> DeleteSubCommentAsync(SubCommentDeleteCommand subCommentDeleteCommand)
        {
            var subCommentResult = await GetSubCommentIfSubCommentExists(subCommentDeleteCommand.subCommentId);
            var deletedSubComment = _subCommentWriteRepository.Remove(subCommentResult);
            await _subCommentWriteRepository.SaveAsync();
            if (!deletedSubComment)
            {
                return false;
            }
            return true;
        }
        #endregion


        #region My Private Methods
        private async Task<AppUser> GetCurrUserAsync() => await _currUserService.GetCurrentUser();
        private async Task<Comment> GetCommentIfCommentExists(string id)
        {
            var result = await _commentReadRepository
                .Table
                .Where
                (p => p.Id == id)
                .FirstOrDefaultAsync();


            if (result == null)
                throw new CommentNotFoundException(result.Id);

            return result;
        }
        private async Task<SubComment> GetSubCommentIfSubCommentExists(string id)
        {
            var result = await _subCommentReadRepository
                .GetWhere(p => p.Id == id)
                .Include(p => p.User)
                .FirstOrDefaultAsync();


            if (result == null)
                throw new SubCommentNotFoundException(result.Id);

            return result;
        }

        



        #endregion

    }
    
}

