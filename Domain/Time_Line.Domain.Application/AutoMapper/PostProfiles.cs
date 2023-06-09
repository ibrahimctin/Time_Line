﻿namespace Time_Line.Domain.Application.AutoMapper
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
                .ForMember(src => src.CommentDetailResponse,
                src => src.MapFrom(dest => dest.Comments));
        }
    }
}
