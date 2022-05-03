using oop_fundamentals.SharedContext;

namespace oop_fundamentals.ContentContext
{
    internal abstract class Content : Base
    {
        public Content(string title, string url)
        {            
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
    }
}
