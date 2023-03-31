namespace ConditionalRemove.RefactoredVersion
{
    public class EventCHandler : IEventHandler
    {
        public bool CanHandle(IEvent @event)
        {
            return @event is EventC;
        }

        public void Handle(IEvent @event)
        {
            var eventC = (EventC)@event;

            eventC.MyCustomMethodOnC();
        }
    }
}