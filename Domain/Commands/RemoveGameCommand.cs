using Core.CQRS;
using System;

namespace Domain.Commands
{
    public class RemoveGameCommand : Command
    {
        public RemoveGameCommand (Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
