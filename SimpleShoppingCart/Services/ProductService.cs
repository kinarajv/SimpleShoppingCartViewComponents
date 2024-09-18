using SimpleShoppingCart.Models;

namespace SimpleShoppingCart.Services;

public class ProductService 
{
  private readonly List<Product> _products;
    
  public ProductService()
  {
    _products = new List<Product>
    {
      new() { Id = 1, Name = "Laptop", Description = "LaptopLaptop", Price = 999.99m, ImageUrl = "/images/laptop.png" },
      new() { Id = 2, Name = "Smartphone", Description = "SmartphoneSmartphone", Price = 699.99m, ImageUrl = "/images/smartphone.png" },
      new() { Id = 3, Name = "Headphones", Description = "HeadphonesHeadphones", Price = 199.99m, ImageUrl = "/images/headphones.png" },
    };
  }
    
  public List<Product> GetAllProducts()
  {
    return _products;
  }
    
  public Product GetProductById(int id)
  {
    return _products.FirstOrDefault(p => p.Id == id);
  }
}
