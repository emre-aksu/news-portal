using AutoMapper;
using Model.Dtos.YazarlarDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class YazarlarProfile:Profile
    {
        public YazarlarProfile()
        {
            CreateMap<Yazarlar, YazarlarGetDto>();
            CreateMap<YazarlarPostDto, Yazarlar>();
            CreateMap<YazarlarPutDto,Yazarlar>();

        }
    }
}
