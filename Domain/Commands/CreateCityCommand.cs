using Core.CQRS;
using Domain.Enums;

namespace Domain.Commands
{
    public class CreateCityCommand : Command
    {
        public CreateCityCommand (string name, State state, int population, int foundationYear)
        {
            Name = name;
            State = state;
            Population = population;
            FoundationYear = foundationYear;
        }
        public string Name { get; set; }
        public State State { get; set; }
        public int Population { get; set; }
        public int FoundationYear { get; set; }
    }
}
