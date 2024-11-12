namespace RikaWebShop.Infrastructure.Interfaces;

public interface IResponseResult : IBaseResponseResult
{
}
public interface IResponseResult<T> : IResponseResult
{
    T? Data { get; set; }
}

