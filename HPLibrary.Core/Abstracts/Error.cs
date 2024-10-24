namespace HPLibrary.Core.Abstracts
{
    public sealed record Error
    {
        public string Message { get; set; }

        public Error(string message)
        {
            Message = message;
        }

        public static readonly Error None = new(string.Empty);
    }
}
