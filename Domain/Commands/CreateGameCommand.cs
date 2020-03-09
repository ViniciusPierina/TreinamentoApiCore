using Core.CQRS;
using Domain.Enums;
using Domain.Models;
using System;

namespace Domain.Commands
{
    public class CreateGameCommand : Command
    {
        public CreateGameCommand(string name, string description, GameType type, int releaseYear, City city, Guid cityId)
        {
            Name = name;
            Description = description;
            Type = type;
            ReleaseYear = releaseYear;
            City = city;
            CityId = cityId;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
    }
}
