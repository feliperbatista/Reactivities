namespace Application.Core;

public class Result<T>
{
    public bool IsSuccess { get; set; }
    public T? Value { get; set; }
    public string? Error { get; set; }
    public int Code { get; set; }

    public static Result<T> Success(T value) => new () { IsSuccess = true, Value = value };
    public static Result<T> Failure(string errror, int code) => new ()
    {
        IsSuccess = false,
        Error = errror,
        Code = code
    };
}