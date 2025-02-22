using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.ResmiIlanlarDto;
using Model.Model;

namespace Business.Implementation
{
    public class ResmiIlanlarManager : IResmiIlanlarManager
    {
        private readonly IResmiIlanlarRepository _rsmRepo;
        private readonly IMapper _mapper;
        public ResmiIlanlarManager(IResmiIlanlarRepository rsmRepo, IMapper mapper)
        {
            _rsmRepo = rsmRepo;
            _mapper = mapper;
        }

        public async Task AddResmi(ResmiIlanlarPostDto dto)
        {
            var entity = _mapper.Map<ResmiIlanlar>(dto);
            await _rsmRepo.InsertAsync(entity);
        }

        public async Task DeleteResmi(int id)
        {
            await _rsmRepo.DeleteAsync(id);
        }

        public async Task<List<ResmiIlanlarGetDto>> GetAllResmi(params string[] includeList)
        {
            List<ResmiIlanlar> resmiIlanlars = await _rsmRepo.GetAllAsync(includeList);
            List<ResmiIlanlarGetDto> list = _mapper.Map<List<ResmiIlanlarGetDto>>(resmiIlanlars);
            return list;

        }

        public async Task<ResmiIlanlarGetDto> GetById(int id, params string[] includeList)
        {
            ResmiIlanlar resmiIlanlar = await _rsmRepo.GetByIdAsync(id, includeList);
            ResmiIlanlarGetDto dto = _mapper.Map<ResmiIlanlarGetDto>(resmiIlanlar);
            return dto;
        }

        public async Task UpdateResmi(ResmiIlanlarPutDto dto)
        {
            var entity = _mapper.Map<ResmiIlanlar>(dto);
            await _rsmRepo.UpdateAsync(entity);
        }
    }
}
