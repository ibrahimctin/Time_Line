namespace Time_Line.Domain.Application.Features.SubComments.Commands.CreateSubComment
{
    public class SubCommentCreateCommandHandler
        : ICommandHandler<SubCommentCreateCommand, SubCommentCreateCommandResponse>
    {
        private ISubCommentService _subCommentService;

        public SubCommentCreateCommandHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<SubCommentCreateCommandResponse> Handle(SubCommentCreateCommand request, CancellationToken cancellationToken)
        {
            var subCommentResult = await _subCommentService.CreateSubCommentAsync(request);
            return new SubCommentCreateCommandResponse
            {
                CreatedSubCommentResponse = subCommentResult
            };
        }
    }
}
