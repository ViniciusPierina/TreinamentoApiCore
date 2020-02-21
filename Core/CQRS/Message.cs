using System;

namespace Core.CQRS
{
    public abstract class Message
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }
        public Guid AggregateId { get; set; }
        public string MessageType { get; set; }
        public DateTime DateTimeStamp { get; set; }
    }
}
