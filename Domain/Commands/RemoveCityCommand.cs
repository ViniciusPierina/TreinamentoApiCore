using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class RemoveCityCommand : Command
    {
        public RemoveCityCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
