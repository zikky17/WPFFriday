using IOT.Resources.Models;

namespace IOT.Resources.Factories;

public static class ResultResponseFactory
{
    public static ResultResponse Success(string? message)
    {
        return new ResultResponse
        {
            Success = true,
            Message = message
        };
    }

    public static ResultResponse Failed(string? message)
    {
        return new ResultResponse
        {
            Success = false,
            Message = message
        };
    }
}

public static class ResultResponseFactory<T>
{
    public static ResultResponse<T> Success(T content, string? message)
    {
        return new ResultResponse<T>
        {
            Success = true,
            Content = content,
            Message = message
        };
    }

    public static ResultResponse<T> Failed(T content, string? message)
    {
        return new ResultResponse<T>
        {
            Success = false,
            Content = content,
            Message = message
        };
    }
}
