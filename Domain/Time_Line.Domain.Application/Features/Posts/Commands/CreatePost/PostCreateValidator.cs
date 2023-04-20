namespace Time_Line.Domain.Application.Features.Posts.Commands.CreatePost
{
    public class PostCreateValidator:AbstractValidator<PostCreateCommand>
    {
        public PostCreateValidator()
        {
            RuleFor(p => p.PostCreateRequest.Title)
                .NotEmpty()
                .NotNull()
                .Length(5, 50);
            RuleFor(p=>p.PostCreateRequest.ContentBody)
                .NotNull()
                .NotEmpty()
                .Length(10, 150);
        }
    }
}
