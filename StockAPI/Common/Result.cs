namespace StockAPI.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }
        public string Error { get; set; }

        private Result(bool  success, T value, string error)
        {
            IsSuccess = success;
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value) =>
            new Result<T>(true, value, string.Empty);

        public static Result<T> Failure(string error) =>
            new Result<T>(false, default!, error);
    }
}
