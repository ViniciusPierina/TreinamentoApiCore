using Core.CQRS;
using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class UpdateGameCommand : Command
    {
        public UpdateGameCommand(Guid id, string name, string description, GameType type, int releaseYear, City city, Guid cityId)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            ReleaseYear = releaseYear;
            City = city;
            CityId = cityId;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
    }
}
