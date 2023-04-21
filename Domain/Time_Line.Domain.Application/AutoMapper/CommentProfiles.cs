namespace Time_Line.Domain.Application.AutoMapper
{
    public class CommentProfiles:Profile
    {
        public CommentProfiles()
        {
            CreateMap<Comment, CommentCreateRequest>()
               .ReverseMap();
            CreateMap<Comment, CommentDetailResponse>()
                .ReverseMap();
            CreateMap<Comment, CommentUpdateRequest>()
                .ReverseMap();
        }
    }
}
