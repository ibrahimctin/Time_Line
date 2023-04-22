namespace Time_Line.Domain.Application.Features.SubComments.Commands.CreateSubComment
{
    public sealed record SubCommentCreateCommand(SubCommentCreateRequest SubCommentCreateRequest)
        :ICommand<SubCommentCreateCommandResponse>
    {
    }
}
