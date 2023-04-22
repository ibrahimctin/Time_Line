namespace Time_Line.Domain.Application.Features.SubComments.Commands.UpdateSubComment
{
    public class SubCommentUpdateCommandHandler
        : ICommandHandler<SubCommentUpdateCommand, SubCommentUpdateCommandResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public SubCommentUpdateCommandHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<SubCommentUpdateCommandResponse> Handle(SubCommentUpdateCommand request, CancellationToken cancellationToken)
        {
            var subCommentResult = await _subCommentService.UpdateSubCommentAsync(request);
            return new SubCommentUpdateCommandResponse
            {
                UpdatedSubCommentResult = subCommentResult
            };
        }
    }
}
