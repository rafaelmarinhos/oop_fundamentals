﻿namespace oop_fundamentals.ContentContext
{
    internal class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }

        public string? Tag { get; set; }
        public IList<Module> Modules { get; set; }
    }
}
