using Model.Dtos.GundemDto;

namespace Business.Contracts
{
    public interface IGundemManager
    {
        Task<GundemGetDto> GetById(int id,params string[] includeList);
        Task<List<GundemGetDto>> GetAllGundem(params string[] includeList);
        Task AddGundem(GundemPostDto dto);
        Task UpdateGundem(GundemPutDto dto);
        Task DeleteGundem(int id);
    }
}
