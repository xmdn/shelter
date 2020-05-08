﻿using BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFGameService
    {
        Task AddGame(GameDTO game);

        Task UpdateGame(GameDTO game);

        Task DeleteGame(int Id);

        Task<GameDTO> GetGameById(int Id);

        Task<IEnumerable<GameDTO>> GetAllGames();

        Task<GameDTO> GetGameByName(string name);

        Task<GameDTO> GetCheapestGame();

    }
}
