using Model.Dtos.SporDto;

namespace Business.Contracts
{
    public interface ISporManager
    {
        Task<SporGetDto> GetById(int id, params string[] inclideList);
        Task<List<SporGetDto>> GetAllSpor( params string[] inclideList);
        Task AddSpor(SporPostDto dto);
        Task UpdateSpor(SporPutDto dto);    
        Task DeleteSpor(int id);
    }
}
