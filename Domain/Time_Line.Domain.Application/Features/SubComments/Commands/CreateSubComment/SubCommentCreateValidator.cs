namespace Time_Line.Domain.Application.Features.SubComments.Commands.CreateSubComment
{
    public class SubCommentCreateValidator:AbstractValidator<SubCommentCreateCommand>
    {
        public SubCommentCreateValidator()
        {
            RuleFor(c => c.SubCommentCreateRequest.ContentBody)
                .NotEmpty()
                .NotNull()
                .Length(1, 150);
        }
    }
}
