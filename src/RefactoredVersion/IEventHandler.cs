namespace ConditionalRemove.RefactoredVersion
{
    public interface IEventHandler
    {
        bool CanHandle(IEvent @event);

        void Handle(IEvent @event);
    }
}