namespace ExcalibPayments.Orders.Damain.Entities;

public class CartEntity : BaseEntity
{
    public List<CartItemEntity>? CartItems { get; set; }
}