﻿using ExcalibPayments.Orders.Application.Abstractions;
using ExcalibPayments.Orders.Application.Models.Orders;
using ExcalibPayments.Orders.Domain;
using ExcalibPayments.Orders.Domain.Entities;

namespace ExcalibPayments.Orders.Application.Services;

public class OrdersService(OrdersDbContext context, ICartsService cartsService) : IOrderService
{
    public async Task<OrderDto> Create(CreateOrderDto order)
    {
        var cart = await cartsService.Create(order.Cart);
        var entity = new OrderEntity
        {
            OrderNumber = order.OrderNumber,
            Name = order.Name,
            CustomerId = order.CustomerId,
            CartId = cart.Id,
        };

        var orderSaveResult = await context.Orders.AddAsync(entity);
        await context.SaveChangesAsync();
        
        var orderEntityResult = orderSaveResult.Entity;

        return new OrderDto
        {
            Id = orderEntityResult.Id,
            OrderNumber = orderEntityResult.OrderNumber,
            Name = orderEntityResult.Name,
            CustomerId = orderEntityResult.CustomerId!.Value,
            Cart = cart,
        };
    }

    public Task<OrderDto> GetById(Guid orderId)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderDto>> GetGyUser(Guid customerId)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Reject(Guid orderId)
    {
        throw new NotImplementedException();
    }
}