using AutoMapper;
using Model.Dtos.SporDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class SporProfile:Profile
    {
        public SporProfile()
        {
            CreateMap<Spor,SporGetDto>();
            CreateMap<SporPostDto, Spor>();
            CreateMap<SporPutDto,Spor>();
        }
    }
}
