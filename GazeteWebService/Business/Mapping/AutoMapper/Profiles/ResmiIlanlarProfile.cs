using AutoMapper;
using Model.Dtos.ResmiIlanlarDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class ResmiIlanlarProfile:Profile
    {
        public ResmiIlanlarProfile()
        {
            CreateMap<ResmiIlanlar, ResmiIlanlarGetDto>();
            CreateMap<ResmiIlanlarPostDto, ResmiIlanlar>();
            CreateMap<ResmiIlanlarPutDto,ResmiIlanlar>();
        }
    }
}
