namespace Time_Line.Domain.Application.AutoMapper
{
    public class SubCommentProfiles:Profile
    {
        public SubCommentProfiles()
        {
            CreateMap<SubComment, SubCommentCreateRequest>()
               .ReverseMap();
            CreateMap<SubComment, SubCommentDetailResponse>()
                .ReverseMap();
            CreateMap<SubComment, SubCommentUpdateRequest>()
                .ReverseMap();
        }
    }
}
