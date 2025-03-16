﻿namespace ExcalibPayments.Orders.Damain.Entities;

public class BaseEntity
{
    public long Id { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public bool IsActive { get; set; }
}