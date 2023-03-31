using System.Collections.Generic;
using System.Linq;

namespace ConditionalRemove.RefactoredVersion
{
    public class EventOrchestrator
    {
        private readonly IEnumerable<IEventHandler> _eventHandlers;

        public EventOrchestrator(IEnumerable<IEventHandler> eventHandlers)
        {
            _eventHandlers = eventHandlers;
        }

        public void Execute(IEvent @event)
        {
            _eventHandlers
                .Single(eventHandler => eventHandler.CanHandle(@event))
                .Handle(@event);
        }
    }
}