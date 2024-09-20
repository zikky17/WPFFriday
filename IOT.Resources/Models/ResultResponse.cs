namespace IOT.Resources.Models;

public class ResultResponse
{
    public bool Success { get; set; }
    public string? Message { get; set; } 
}

public class ResultResponse<T> : ResultResponse
{
    public T? Content { get; set; }
}
