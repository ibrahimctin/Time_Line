namespace Time_Line.Domain.Application.AutoMapper
{
    public class PostProfiles:Profile
    {
        public PostProfiles()
        {
            CreateMap<Post, PostCreateRequest>()
                .ReverseMap();
            CreateMap<Post, PostDetailResponse>()
                .ReverseMap();
            CreateMap<Post, PostUpdateRequest>()
                .ReverseMap();
            CreateMap<Post, PostCommentListResponse>()
                .ReverseMap()
                .ForMember(src => src.Comments,
                src => src.MapFrom(dest => dest.CommentDetailResponse));
        }
    }
}
