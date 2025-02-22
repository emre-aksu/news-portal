using Model.Dtos.YazarlarDto;

namespace Business.Contracts
{
    public interface IYazarlarManager
    {
        Task<YazarlarGetDto> GetById(int id, params string[] includeList);
        Task<List<YazarlarGetDto>> GetAllyazarlar(params string[] includeList);
        Task AddYazarlar(YazarlarPostDto dto);
        Task UpdateYazarlar(YazarlarPutDto dto);
        Task DeleteYazarlar(int id);
    }
}
