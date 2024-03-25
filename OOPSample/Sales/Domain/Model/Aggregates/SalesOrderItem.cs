namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem
{
    public SalesOrderItem(Guid salesOrderId, int productId, int quantity, double unitPrice)
    {
        SalesOrderId = salesOrderId;
        Id = Guid.NewGuid();
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public Guid SalesOrderId { get; }
    public Guid Id { get; }
    public int ProductId { get; }
    public int Quantity { get; }
    public double UnitPrice { get; }

    public double CalculateItemPrice() => Quantity * UnitPrice;
}