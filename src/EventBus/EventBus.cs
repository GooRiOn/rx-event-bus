using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using EDA.Events;

namespace EDA.EventBus
{
    internal sealed class EventBus : IEventBus
    {
        private readonly Subject<IEvent> _subject = new Subject<IEvent>();
        
        public void Publish<TEvent>(TEvent @event) where TEvent : class, IEvent
            => _subject.OnNext(@event);

        public IObserver<TEvent> Subscribe<TEvent>(Action<TEvent> onNext) where TEvent : class, IEvent
        {
            var observer = new AnonymousObserver<TEvent>(onNext);
            _subject.OfType<TEvent>().Subscribe(observer);

            return observer;
        }
    }
}