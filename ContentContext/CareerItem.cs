using oop_fundamentals.NotificationContext;
using oop_fundamentals.SharedContext;

namespace oop_fundamentals.ContentContext
{
    internal class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
            {
                AddNotification(new Notification("Course", "O curso não pode ser vazio."));
            }

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
