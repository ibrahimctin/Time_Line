namespace Time_Line.Domain.Application.Features.Comments.Commands.UpdateComment
{
    public class CommentUpdateValidator:AbstractValidator<CommentUpdateCommand>
    {
        public CommentUpdateValidator()
        {
            RuleFor(c => c.CommentUpdateRequest.ContentBody)
              .NotEmpty()
              .NotNull()
              .Length(1, 150);
        }
    }
}
