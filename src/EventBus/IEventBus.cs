using System;
using EDA.Events;

namespace EDA.EventBus
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event) where TEvent : class, IEvent;
        IObserver<TEvent> Subscribe<TEvent>(Action<TEvent> onNext) where TEvent : class, IEvent;
    }
}