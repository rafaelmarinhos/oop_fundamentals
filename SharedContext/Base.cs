using oop_fundamentals.NotificationContext;

namespace oop_fundamentals.SharedContext
{
    internal abstract class Base : Notifiable
    {
        protected Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
