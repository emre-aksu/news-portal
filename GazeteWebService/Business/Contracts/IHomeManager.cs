﻿using Model.Dtos.HomeDto;

namespace Business.Contracts
{
    public interface IHomeManager
    {
        Task<HomeGetDto> GetById(int id,params string[] includeList);
        Task<List<HomeGetDto>> GetAllHome(params string[] includeList);
        Task AddHome(HomePostDto dto);
        Task UpdateHome(HomePutDto dto);
        Task DeleteHome(int id);
    }
}
