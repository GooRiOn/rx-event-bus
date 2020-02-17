using System;
using EDA.Events;

namespace EDA
{
    class Program
    {
        static void Main(string[] args)
        {
           var eventBus = new EventBus.EventBus();
           eventBus.Subscribe<TestEvent>(e => Console.WriteLine($"I'm a subscriber 1. Got event with value: {e.Value}"));
           eventBus.Subscribe<TestEvent>(e => Console.WriteLine($"I'm a subscriber 2. Got event with value: {e.Value}"));
           eventBus.Subscribe<TestEvent>(e => Console.WriteLine($"I'm a subscriber 3. Got event with value: {e.Value}"));
           eventBus.Subscribe<TestEvent>(e => Console.WriteLine($"I'm a subscriber 4. Got event with value: {e.Value}"));

           eventBus.Publish(new TestEvent("Value1"));
        }
    }
}