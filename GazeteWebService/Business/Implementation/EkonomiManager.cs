using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.EkonomiDto;
using Model.Model;

namespace Business.Implementation
{
    public class EkonomiManager:IEkonomiManager
    {
        private readonly IEkonomiRepository _eknmRepo;
        private readonly IMapper _mapper;
        public EkonomiManager(IEkonomiRepository eknmRepo, IMapper mapper) 
        {
            _eknmRepo = eknmRepo;
            _mapper = mapper;
        }

        public async Task AddEkonomi(EkonomiPostDto dto)
        {
            var entity = _mapper.Map<Ekonomi>(dto);
            await _eknmRepo.InsertAsync(entity);
        }

        public async Task DeleteEkonomi(int id)
        {
            await _eknmRepo.DeleteAsync(id);
        }

        public async Task<List<EkonomiGetDto>> GetAllEkonomi(params string[] includeList)
        {
           List<Ekonomi> ekonomies = await _eknmRepo.GetAllAsync(includeList);
            List<EkonomiGetDto> list = _mapper.Map<List<EkonomiGetDto>>(ekonomies);
            return list;
        }
        // gitgub deneme
        public async Task<EkonomiGetDto> GetById(int id, params string[] includeList)
        {
            Ekonomi ekonomies = await _eknmRepo.GetByIdAsync(id, includeList);
            EkonomiGetDto dto = _mapper.Map<EkonomiGetDto>(ekonomies);
            return dto;
        }

        public async Task UpdateEkonomi(EkonomiPutDto dto)
        {
            var entity = _mapper.Map<Ekonomi>(dto); 
            await  _eknmRepo.UpdateAsync(entity);
        }
    }
}
