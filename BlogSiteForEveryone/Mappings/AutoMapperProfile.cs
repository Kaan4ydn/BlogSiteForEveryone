using AutoMapper;
using BLL.DTOs;
using BlogSiteForEveryone.Models;

namespace BlogSiteForEveryone.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, UserViewModel>().ReverseMap();
            CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
            CreateMap<PostDto, PostViewModel>().ReverseMap();
            CreateMap<ComplainDto, ComplainViewModel>().ReverseMap();
        }
    }
}
