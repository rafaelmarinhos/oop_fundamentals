namespace oop_fundamentals.ContentContext
{
    internal abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int Nome { get; set; }
        public int Url { get; set; }
    }
}
