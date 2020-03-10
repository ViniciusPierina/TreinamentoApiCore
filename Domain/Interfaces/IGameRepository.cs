using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IGameRepository : IRepository<Game>
    {
        IEnumerable<Game> FindGameByReleaseYear(int year);
        IEnumerable<Game> FindAllGames();
    }
}
