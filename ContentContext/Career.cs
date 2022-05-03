namespace oop_fundamentals.ContentContext
{
    internal class Career : Content
    {
        public Career(string title, string url) 
            : base(title, url)
        {
            Courses = new List<CareerItem>();
        }

        public IList<CareerItem> Courses { get; set; }

        public int TotalCourses => Courses.Count;
    }
}
