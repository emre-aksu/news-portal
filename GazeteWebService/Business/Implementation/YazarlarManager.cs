using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.YazarlarDto;
using Model.Model;

namespace Business.Implementation
{
    public class YazarlarManager:IYazarlarManager
    {
        private readonly IYazarlarRepository _yzrRepo;
        private readonly IMapper _mapper;
        public YazarlarManager(IYazarlarRepository yzrRepo,IMapper mapper)
        {
            _yzrRepo = yzrRepo;
            _mapper = mapper;
        }

        public async Task AddYazarlar(YazarlarPostDto dto)
        {
            var entity = _mapper.Map<Yazarlar>(dto);
            await _yzrRepo.InsertAsync(entity);
         
        }

        public async Task DeleteYazarlar(int id)
        {
            await _yzrRepo.DeleteAsync(id);
        }

        public async Task<List<YazarlarGetDto>> GetAllyazarlar(params string[] includeList)
        {
            List<Yazarlar> yazarlars = await _yzrRepo.GetAllAsync();
            List<YazarlarGetDto> list = _mapper.Map<List<YazarlarGetDto>>(includeList);
            return list;
        }

        public async Task<YazarlarGetDto> GetById(int id, params string[] includeList)
        {
            Yazarlar yazarlar = await _yzrRepo.GetByIdAsync(id, includeList);
            YazarlarGetDto dto = _mapper.Map<YazarlarGetDto>(yazarlar);
            return dto;
        }

        public async Task UpdateYazarlar(YazarlarPutDto dto)
        {
            var entity = _mapper.Map<Yazarlar>(dto); 
            await _yzrRepo.UpdateAsync(entity);
        }
    }
}
