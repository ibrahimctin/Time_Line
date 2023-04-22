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
            CreateMap<Comment, CommentSubCommentsListResposne>()
             .ForMember(src => src.SubCommentDetailResponse,
             src => src.MapFrom(dest => dest.SubComments));
        }
    }
}
