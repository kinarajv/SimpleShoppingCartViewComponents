using SimpleShoppingCart.Models;

namespace ShoppingCartSample.ViewComponents.ViewModel;

public class ShoppingCartViewModel
{
  public List<CartItem> Items { get; set; }
  public decimal Total { get; set; }
  public int ItemCount { get; set; }
}