using oop_fundamentals.ContentContext.enums;
using oop_fundamentals.SharedContext;

namespace oop_fundamentals.ContentContext
{
    internal class Lecture : Base
    {
        public int Order { get; set; }
        public string? Title { get; set; }        
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
