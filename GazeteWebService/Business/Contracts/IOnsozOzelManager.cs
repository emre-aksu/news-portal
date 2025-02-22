using Model.Dtos.OnsozOzelDto;

namespace Business.Contracts
{
    public interface IOnsozOzelManager 
    {
        Task<OnsozOzelGetDto> GetById(int id, params string[] includeList);
        Task<List<OnsozOzelGetDto>> GetAllOnsoz( params string[] includeList);
        Task AddOnsoz(OnsozOzelPostDto dto);
        Task UpdateOnsoz(OnsozOzelPutDto dto);
        Task DeleteOnsoz(int id);
    }
}
