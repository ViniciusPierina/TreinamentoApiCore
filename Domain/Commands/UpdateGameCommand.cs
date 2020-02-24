using Core.CQRS;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class UpdateGameCommand : Command
    {
        public UpdateGameCommand(Guid id, string name, string description, GameType type, int releaseYear)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            ReleaseYear = releaseYear;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
    }
}
