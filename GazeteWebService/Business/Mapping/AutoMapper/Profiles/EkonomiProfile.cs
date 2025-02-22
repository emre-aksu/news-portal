using AutoMapper;
using Model.Dtos.EkonomiDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class EkonomiProfile:Profile
    {
        public EkonomiProfile()
        {
            CreateMap<Ekonomi, EkonomiGetDto>();
            CreateMap<EkonomiPostDto, Ekonomi>();
            CreateMap<EkonomiPutDto, Ekonomi>();
        }
    }
}
