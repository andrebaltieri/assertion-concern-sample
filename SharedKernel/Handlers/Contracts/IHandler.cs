using System;
using System.Collections.Generic;
using FluntSpec.SharedKernel.Events.Contracts;

namespace FluntSpec.SharedKernel.Handlers.Contracts
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}