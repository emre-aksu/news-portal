using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.HomeDto;
using Model.Model;

namespace Business.Implementation
{
    public class HomeManager : IHomeManager
    {
        private readonly IHomeRepository _hmRepo;
        private readonly IMapper _mapper;
        public HomeManager(IHomeRepository hmRepo, IMapper mapper)
        {
            _hmRepo = hmRepo;
            _mapper = mapper;
        }

        public async Task AddHome(HomePostDto dto)
        {
            var entity = _mapper.Map<Home>(dto);
            await _hmRepo.InsertAsync(entity);
        }

        public async Task DeleteHome(int id)
        {
            await _hmRepo.DeleteAsync(id);
        }

        public async Task<List<HomeGetDto>> GetAllHome(params string[] includeList)
        {
            List<Home> homes = await _hmRepo.GetAllAsync(includeList);
            List<HomeGetDto> list = _mapper.Map<List<HomeGetDto>>(homes);
            return list;
        }

        public async Task<HomeGetDto> GetById(int id, params string[] includeList)
        {
            Home homes = await _hmRepo.GetByIdAsync(id, includeList);
            HomeGetDto dto = _mapper.Map<HomeGetDto>(homes);
            return dto;
        }

        public async Task UpdateHome(HomePutDto dto)
        {
            var entity = _mapper.Map<Home>(dto);
            await _hmRepo.UpdateAsync(entity);
        }
    }
}
