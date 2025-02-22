using AutoMapper;
using Model.Dtos.HomeDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class HomeProfile:Profile
    {
        public HomeProfile()
        {
            CreateMap<Home,HomeGetDto>();
            CreateMap<HomePostDto, Home>();
            CreateMap<HomePutDto, Home>();
        }
    }
}
