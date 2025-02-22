using Model.Dtos.ResmiIlanlarDto;

namespace Business.Contracts
{
    public interface IResmiIlanlarManager 
    {
        Task<ResmiIlanlarGetDto> GetById(int id,params string[] includeList);
        Task<List<ResmiIlanlarGetDto>> GetAllResmi(params string[] includeList);
        Task AddResmi(ResmiIlanlarPostDto dto);
        Task UpdateResmi(ResmiIlanlarPutDto dto);   
        Task DeleteResmi(int id);   
    }
}
