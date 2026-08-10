namespace StockAPI.Common
{
    public class Result
    {
        public bool IsSuccess { get; }
        public string Error { get; }

        protected Result(bool success, string error)
        {
            IsSuccess = success;
            Error = error;
        }

        public static Result Success() => new(true, string.Empty);
        public static Result Failure(string erro) =>
            new(false, erro);
    }

    public class Result<T> : Result
    {
        public T Value { get; }

        private Result(bool success, T value, string error) : base(success, error)
        {
            Value = value;
        }

        public static Result<T> Success(T value) =>
            new Result<T>(true, value, string.Empty);

        public static new Result<T> Failure(string error) =>
            new Result<T>(false, default!, error);
    }
}
