using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.GundemDto;
using Model.Model;

namespace Business.Implementation
{
    public class GundemManager : IGundemManager
    {
        private readonly IGundemRepository _gndmRepo;
        private readonly IMapper _mapper;
        public GundemManager(IGundemRepository gndmRepo, IMapper mapper)
        {
            _gndmRepo = gndmRepo;
            _mapper = mapper;
        }

        public async Task AddGundem(GundemPostDto dto)
        {
            var entity = _mapper.Map<Gundem>(dto);
            await _gndmRepo.InsertAsync(entity);
        }

        public async Task DeleteGundem(int id)
        {
            await _gndmRepo.DeleteAsync(id);
        }

        public async Task<List<GundemGetDto>> GetAllGundem(params string[] includeList)
        {
            List<Gundem> gundems = await _gndmRepo.GetAllAsync(includeList);
            List<GundemGetDto> list = _mapper.Map<List<GundemGetDto>>(gundems);
            return list;
        }

        public async Task<GundemGetDto> GetById(int id, params string[] includeList)
        {
            Gundem gundems = await _gndmRepo.GetByIdAsync(id, includeList);
            GundemGetDto dto = _mapper.Map<GundemGetDto>(gundems);
            return dto;
        }

        public async Task UpdateGundem(GundemPutDto dto)
        {
            var entity = _mapper.Map<Gundem>(dto);
            await _gndmRepo.UpdateAsync(entity);
        }
    }
}
