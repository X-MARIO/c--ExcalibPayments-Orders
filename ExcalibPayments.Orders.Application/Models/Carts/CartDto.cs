namespace ExcalibPayments.Orders.Application.Models.Carts;

public class CartDto
{
    public long? Id { get; set; } = null;
    
    public List<CartItemDto> CartItems { get; set; } = null!;
}