using AutoMapper;
using Business.Contracts;
using DataAccess.Contracts.Repositories;
using Model.Dtos.OnsozOzelDto;
using Model.Model;

namespace Business.Implementation
{
    public class OnsozManager : IOnsozOzelManager
    {
        private readonly IOnsozRepository _onszRepo;
        private readonly IMapper _mapper;
        public OnsozManager(IOnsozRepository onszRepo, IMapper mapper)
        {
            _onszRepo = onszRepo;
            _mapper = mapper;
        }

        public async Task AddOnsoz(OnsozOzelPostDto dto)
        {
            var entity = _mapper.Map<OnsozOzel>(dto);
            await _onszRepo.InsertAsync(entity);
        }

        public async Task DeleteOnsoz(int id)
        {
            await _onszRepo.DeleteAsync(id);
        }

        public async Task<List<OnsozOzelGetDto>> GetAllOnsoz(params string[] includeList)
        {
            List<OnsozOzel> onsozOzels = await _onszRepo.GetAllAsync(includeList);
            List<OnsozOzelGetDto> list = _mapper.Map<List<OnsozOzelGetDto>>(onsozOzels);
            return list;
        }

        public Task<OnsozOzelGetDto> GetById(int id, params string[] includeList)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOnsoz(OnsozOzelPutDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
