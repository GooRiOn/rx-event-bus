namespace EDA.Events
{
    public class TestEvent : IEvent
    {
        public string Value { get; }

        public TestEvent(string value)
        {
            Value = value;
        }
    }
}