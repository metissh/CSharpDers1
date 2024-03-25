namespace CSharpDers.Entities;

public class CorporateCustomer:BaseCustomer
{
    public int Id { get; set; }
    public string CustomerNumber { get; set; }
    public string Name { get; set; }
    public string TaxNumber { get; set; }

}
