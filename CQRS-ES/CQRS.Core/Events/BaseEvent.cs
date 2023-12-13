using CQRS.Core.Messages;

namespace CQRS.Core.Events
{
    public abstract class BaseEvent : Message
    {

        protected BaseEvent(string type)
        {
            Type = type;
        }

        //this is our discriminator property that we use when we do polymorphic data binding when we are serializing our event objects.
        public string Type { get; set; }

        //we will need a version when we replay the latest state of the aggregate
        public int Version { get; set; }
    }
}