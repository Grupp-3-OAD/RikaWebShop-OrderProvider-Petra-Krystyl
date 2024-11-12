using RikaWebShop.Infrastructure.Interfaces;

namespace RikaWebShop.Infrastructure.Models;

public class BaseResponseResult : IBaseResponseResult
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public string? Message { get; set; }
}

public class ResponseResult : BaseResponseResult, IResponseResult
{ }

public class ResponseResult<T> : BaseResponseResult, IResponseResult<T>
{
    public T? Data { get; set; }
}


