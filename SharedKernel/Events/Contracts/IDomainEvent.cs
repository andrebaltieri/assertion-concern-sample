using System;

namespace FluntSpec.SharedKernel.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime Date { get; }
    }
}