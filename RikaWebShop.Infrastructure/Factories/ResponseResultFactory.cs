using RikaWebShop.Infrastructure.Interfaces;
using RikaWebShop.Infrastructure.Models;

namespace RikaWebShop.Infrastructure.Factories;

public abstract class ResponseResultFactory
{
    public static IResponseResult Success(int statusCode = 200, string message = null!)
    {
        return new ResponseResult
        {
            Success = true,
            StatusCode = statusCode,
            Message = message
        };
    }

    public static IResponseResult Success<T>(int statusCode = 200, T data = default!, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = true,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }

    public static IResponseResult Failed(int statusCode = 400, string? message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            StatusCode = statusCode,
            Message = message

        };
    }

    public static IResponseResult Failed<T>(int statusCode = 400, T data = default!, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }


    public static IResponseResult NotFound(int statusCode = 404, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            StatusCode = statusCode,
            Message = message
        };
    }

    public static IResponseResult NotFound<T>(int statusCode = 404, T data = default!, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }

    public static IResponseResult AlreadExists(int statusCode = 409, string? message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            StatusCode = statusCode,
            Message = message

        };
    }

    public static IResponseResult AlreadyExists<T>(int statusCode = 409, T data = default!, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
}
