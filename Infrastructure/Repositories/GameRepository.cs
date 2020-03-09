using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        private readonly ConfigurationContext configurationContext;

        public GameRepository(ConfigurationContext context) : base(context)
        {
            configurationContext = context;
        }

        public IEnumerable<Game> FindAllGames()
        {
            return configurationContext.Set<Game>().Where(t => !t.Deleted).Include(g => g.City).ToList();
        }

        public IEnumerable<Game> FindGameByReleaseYear(int year)
        {
            return configurationContext.Games.Where(game => game.ReleaseYear == year);
        }
    }
}
