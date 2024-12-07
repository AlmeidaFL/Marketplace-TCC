namespace CatalogBff.Domain;

public class DeliveryAddress
{
    public string? Id {get; set;}
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Number { get; set; }
}