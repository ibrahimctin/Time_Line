namespace Time_Line.Domain.Application.Features.Comments.Commands.CreateComment
{
    public class CommentCreateValidator:AbstractValidator<CommentCreateCommand>
    {
        public CommentCreateValidator()
        {
            RuleFor(c => c.CommentCreateRequest.ContentBody)
                .NotEmpty()
                .NotNull()
                .Length(1, 150);
        }
    }
}
