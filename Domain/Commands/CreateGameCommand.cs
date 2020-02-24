using Core.CQRS;
using Domain.Enums;

namespace Domain.Commands
{
    public class CreateGameCommand : Command
    {
        public CreateGameCommand(string name, string description, GameType type, int releaseYear)
        {
            Name = name;
            Description = description;
            Type = type;
            ReleaseYear = releaseYear;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
    }
}
