namespace ConditionalRemove.RefactoredVersion
{
    public class EventBHandler : IEventHandler
    {
        public bool CanHandle(IEvent @event)
        {
            return @event is EventB;
        }

        public void Handle(IEvent @event)
        {
            var eventB = (EventB)@event;

            eventB.MyCustomMethodOnB();
            eventB.SomeAdditionalMethodB();
        }
    }
}