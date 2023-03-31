namespace ConditionalRemove.RefactoredVersion
{
    public class EventAHandler : IEventHandler
    {
        public bool CanHandle(IEvent @event)
        {
            return @event is EventA;
        }

        public void Handle(IEvent @event)
        {
            var eventA = (EventA)@event;
            eventA.MyCustomMethodOnA();
        }
    }
}