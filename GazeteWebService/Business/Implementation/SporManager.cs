using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.SporDto;
using Model.Model;

namespace Business.Implementation
{
    public class SporManager : ISporManager
    {
        private readonly ISporRepository _sprRepo;
        private readonly IMapper _mapper;
        public SporManager(ISporRepository sprRepo, IMapper mapper)
        {
             _sprRepo = sprRepo;
            _mapper = mapper;   
        }

        public async Task AddSpor(SporPostDto dto)
        {
            var entity = _mapper.Map<Spor>(dto);
            await _sprRepo.InsertAsync(entity);
        }

        public async Task DeleteSpor(int id)
        {
           await _sprRepo.DeleteAsync(id);
        }

        public async Task<List<SporGetDto>> GetAllSpor( params string[] inclideList) 
        {
            List<Spor> spors = await _sprRepo.GetAllAsync(inclideList);
            List<SporGetDto> list = _mapper.Map<List<SporGetDto>>(spors);
            return list;
        }

        public async Task<SporGetDto> GetById(int id, params string[] inclideList)
        {
            Spor spors = await _sprRepo.GetByIdAsync(id, inclideList);
            SporGetDto dto = _mapper.Map<SporGetDto>(spors);
            return dto;
        }

        public async Task UpdateSpor(SporPutDto dto)
        {
            var entity = _mapper.Map<Spor>(dto);
            await _sprRepo.UpdateAsync(entity); 
        }
    }
}
