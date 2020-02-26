using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IGameService
    {
        void Save(CreateGameDTO model);
        void Update(UpdateGameDTO model);
        void Delete(Guid Id);
        GameDTO Get(Guid Id);
        IEnumerable<GameDTO> GetAll();
        IEnumerable<GameDTO> FindGameByReleaseYear(int year);
    }
}
