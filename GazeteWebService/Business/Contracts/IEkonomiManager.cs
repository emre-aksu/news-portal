using Model.Dtos.EkonomiDto;

namespace Business.Contracts
{
    public interface IEkonomiManager 
    {
        Task<EkonomiGetDto> GetById(int id, params string[] includeList);
        Task<List<EkonomiGetDto>> GetAllEkonomi(params string[] includeList);
        Task AddEkonomi(EkonomiPostDto dto);
        Task UpdateEkonomi(EkonomiPutDto dto);
        Task DeleteEkonomi(int id);
    }
}
