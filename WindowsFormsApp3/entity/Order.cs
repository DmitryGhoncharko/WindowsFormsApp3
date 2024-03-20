// Класс для представления заказа

using System;

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderType { get; set; }
}