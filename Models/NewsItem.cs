namespace AsyncWebScraper.Models
{
    internal class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public DateTime ScrapedAt { get; set; }

    }
}
