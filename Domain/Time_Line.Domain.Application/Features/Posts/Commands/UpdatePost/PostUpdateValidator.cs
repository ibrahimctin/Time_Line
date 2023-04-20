namespace Time_Line.Domain.Application.Features.Posts.Commands.UpdatePost
{
    public class PostUpdateValidator:AbstractValidator<PostUpdateCommand>
    {
        public PostUpdateValidator()
        {
            RuleFor(p => p.PostUpdateRequest.Title)
                .NotEmpty()
                .NotNull()
                .Length(5, 50);
            RuleFor(p => p.PostUpdateRequest.ContentBody)
                .NotNull()
                .NotEmpty()
                .Length(10, 150);
        }
    }
}
