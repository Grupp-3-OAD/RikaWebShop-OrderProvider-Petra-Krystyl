using RikaWebShop.Infrastructure.Factories;
using RikaWebShop.Infrastructure.Models;

namespace RikaWebShop.Infrastructure_Tests.Services;

public class OrderFactory_Tests
{

    private OrderUpdateRequest _updateOrderRequest = new OrderUpdateRequest
    {
        OrderNumber = "123",
        TotalPrice = 900,
        FirstName = "Nisse",
        LastName = "Tomtenisse",
        Email = "Nissen@domain.com",
        PhoneNumber = "9999999",
        DeliveryAddress = new DeliveryAddress
        {
            City = "Nordpolen",
            Country = "Nordpolen",
            StreetName = "Nordpolsvägen",
            StreetNumber = "33",
            ZipCode = "111111"
        }
    };
    private OrderEntity _orderEntityWithData = new OrderEntity
    {
        OrderNumber = "123",
        TotalPrice = 900,
        FirstName = "Nisse",
        LastName = "Tomtenisse",
        Email = "Nissen@domain.com",
        PhoneNumber = "9999999",
        DeliveryAddress = new DeliveryAddress
        {
            City = "Nordpolen",
            Country = "Nordpolen",
            StreetName = "Nordpolsvägen",
            StreetNumber = "33",
            ZipCode = "111111"
        },
        Created = DateTime.Now
    };
    private Order _order = new Order
    {
        OrderNumber = "123",
        TotalPrice = 900,
        FirstName = "Nisse",
        LastName = "Tomtenisse",
        Email = "Nissen@domain.com",
        PhoneNumber = "9999999",
        DeliveryAddress = new DeliveryAddress
        {
            City = "Nordpolen",
            Country = "Nordpolen",
            StreetName = "Nordpolsvägen",
            StreetNumber = "33",
            ZipCode = "111111"
        }
    };
    private OrderRequest _orderRequest = new OrderRequest
    {
        TotalPrice = 900,
        FirstName = "Nisse",
        LastName = "Tomtenisse",
        Email = "Nissen@domain.com",
        PhoneNumber = "9999999",
        DeliveryAddress = new DeliveryAddress
        {
            City = "Nordpolen",
            Country = "Nordpolen",
            StreetName = "Nordpolsvägen",
            StreetNumber = "33",
            ZipCode = "111111"
        }
    };
    [Fact]
    public void Create_ShouldReturnOrderEntity_FromOrderRequest()
    {
        var result = OrderFactory.Create(_orderRequest);
        Assert.IsType<OrderEntity>(result);
    }
    [Fact]
    public void Create_ShouldReturnOrder_FromOrderEntity()
    {
        var result = OrderFactory.Create(_orderEntityWithData);
        Assert.IsType<Order>(result);   
    }
    [Fact]
    public void Create_ShouldReturnOrderEntity_FromOrderUpdateRequest()
    {
        var result = OrderFactory.Create(_updateOrderRequest);
        Assert.IsType<OrderEntity>(result);
    }
    [Fact]
    public void Create_ShouldReturnIEnumerableListOfOrders_FromListOfOrderEntities()
    {
        List<OrderEntity> list = [_orderEntityWithData, _orderEntityWithData];
        var result = OrderFactory.Create(list);
        Assert.IsAssignableFrom<IEnumerable<Order>>(result);
    }
}
