namespace HPLibrary.Core.Abstracts
{
    public class Result<TValue> : Result
    {
        public TValue? Value { get; set; }

        public Result(TValue? value, bool isSuccess, Error error)
            : base(isSuccess, error)
        {
            Value = value;
        }

        public static Result<TValue> Success(TValue value) => new(value, true, Error.None);
        public static Result<TValue> Failure(Error error) => new(default, false, error);
    }

    public class Result
    {
        public bool IsSuccess { get; set; }
        public bool IsFailure { get; set; }
        public Error Error { get; set; }

        public Result(bool isSuccess, Error error)
        {
            IsSuccess = isSuccess;
            IsFailure = !isSuccess;
            Error = error;
        }

        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);
    }
}
