using AutoMapper;
using Model.Dtos.OnsozOzelDto;
using Model.Model;

namespace Business.Mapping.AutoMapper.Profiles
{
    public class OnsozProfile:Profile
    {
        public OnsozProfile()
        {
            CreateMap<OnsozOzel, OnsozOzelGetDto>();
            CreateMap<OnsozOzelPostDto, OnsozOzel>();
            CreateMap<OnsozOzelPutDto, OnsozOzel>();
        }
    }
}
