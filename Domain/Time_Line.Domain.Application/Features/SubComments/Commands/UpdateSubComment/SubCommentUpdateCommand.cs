namespace Time_Line.Domain.Application.Features.SubComments.Commands.UpdateSubComment
{
    public sealed record SubCommentUpdateCommand(SubCommentUpdateRequest SubCommentUpdateRequest)
        :ICommand<SubCommentUpdateCommandResponse>
    {
    }
}
