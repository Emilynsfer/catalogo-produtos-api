namespace CatalogoProdutosMinimalAPI.Models;

public class Product
{
    public int Id { get; set; } // PK
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
