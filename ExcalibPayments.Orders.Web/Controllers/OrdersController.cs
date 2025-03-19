using System.Text.Json;
using ExcalibPayments.Orders.Application.Abstractions;
using ExcalibPayments.Orders.Application.Models.Orders;
using Microsoft.AspNetCore.Mvc;

namespace ExcalibPayments.Orders.Web.Controllers;

[Route("api/orders")]
public class OrdersController(IOrderService orders, ILogger<OrdersController> logger) : ApiBaseController
{
    [HttpPost("create")]
    public async Task<IActionResult> Create(CreateOrderDto request)
    {
        logger.LogInformation($"Method api/orders/create started. Request : {JsonSerializer.Serialize(request)}");

        var result = await orders.Create(request);

        logger.LogInformation($"Method api/orders/create finished. Request : {JsonSerializer.Serialize(request)}" +
                              $"Reponse: {JsonSerializer.Serialize(result)}");

        return Ok(result);
    }
}