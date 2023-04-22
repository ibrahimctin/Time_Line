namespace Time_Line.Domain.Application.Features.SubComments.Commands.UpdateSubComment
{
    public class SubCommentUpdateValidator:AbstractValidator<SubCommentUpdateCommand>
    {
        public SubCommentUpdateValidator()
        {
            RuleFor(c => c.SubCommentUpdateRequest.ContentBody)
               .NotEmpty()
               .NotNull()
               .Length(1, 150);
        }
    }
}
