namespace HPLibrary.Core.Contracts
{
    public record Book
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string ReleaseDate { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
    }
}
