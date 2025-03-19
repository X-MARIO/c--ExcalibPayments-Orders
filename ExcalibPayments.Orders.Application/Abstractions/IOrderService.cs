using ExcalibPayments.Orders.Application.Models.Orders;

namespace ExcalibPayments.Orders.Application.Abstractions;

public interface IOrderService
{
    Task<OrderDto> Create(CreateOrderDto order);

    Task<OrderDto> GetById(Guid orderId);

    Task<List<OrderDto>> GetGyUser(Guid customerId);

    Task<List<OrderDto>> GetAll();

    Task Reject(Guid orderId);
}