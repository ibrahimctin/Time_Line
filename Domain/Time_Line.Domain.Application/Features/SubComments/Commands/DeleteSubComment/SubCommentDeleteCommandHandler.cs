namespace Time_Line.Domain.Application.Features.SubComments.Commands.DeleteSubComment
{
    public class SubCommentDeleteCommandHandler
        : ICommandHandler<SubCommentDeleteCommand, SubCommentDeleteCommandResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public SubCommentDeleteCommandHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<SubCommentDeleteCommandResponse> Handle(SubCommentDeleteCommand request, CancellationToken cancellationToken)
        {
            var subCommentResult = await _subCommentService.DeleteSubCommentAsync(request);
            return new SubCommentDeleteCommandResponse
            {
                DeletedSubCommentResult = subCommentResult
            };
        }
    }
}
