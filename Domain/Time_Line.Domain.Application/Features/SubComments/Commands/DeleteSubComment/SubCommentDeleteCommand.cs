namespace Time_Line.Domain.Application.Features.SubComments.Commands.DeleteSubComment
{
    public sealed record SubCommentDeleteCommand(string subCommentId)
        :ICommand<SubCommentDeleteCommandResponse>
    {
    }
}
