using Core.CQRS;
using Domain.Enums;
using System;

namespace Domain.Commands
{
    public class UpdateCityCommand : Command
    {
        public UpdateCityCommand(Guid id, string name, State state, int population, int foundationYear)
        {
            Id = id;
            Name = name;
            State = state;
            Population = population;
            FoundationYear = foundationYear;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public int Population { get; set; }
        public int FoundationYear { get; set; }
    }
}
