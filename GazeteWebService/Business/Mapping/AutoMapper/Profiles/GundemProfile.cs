using AutoMapper;
using Model.Dtos.GundemDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class GundemProfile:Profile
    {
        public GundemProfile()
        {
            CreateMap<Gundem,GundemGetDto>();
            CreateMap<GundemPostDto, Gundem>();
            CreateMap<GundemPutDto, Gundem>();
        }
    }
}
