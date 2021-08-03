using System;
using FluntSpec.SharedKernel.Events.Contracts;

namespace FluntSpec.SharedKernel.Events
{
    public class DomainNotification : IDomainEvent
    {
        public DomainNotification(string key, string message)
        {
            Key = key;
            Message = message;
            Date = DateTime.Now;
        }

        public string Key { get; private set; }
        public string Message { get; private set; }
        public DateTime Date { get; private set; }
    }
}