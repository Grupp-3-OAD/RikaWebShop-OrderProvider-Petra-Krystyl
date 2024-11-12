namespace RikaWebShop.Infrastructure.Interfaces;

public interface IBaseResponseResult
{
    string? Message { get; set; }
    int StatusCode { get; set; }
    bool Success { get; set; }
}