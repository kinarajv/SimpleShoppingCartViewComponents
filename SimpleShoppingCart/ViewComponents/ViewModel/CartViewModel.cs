using SimpleShoppingCart.Models;

namespace ShoppingCartSample.ViewComponents.ViewModel;

public class CartViewModel
{
  public List<CartItem> Items { get; set; }
  public decimal Total { get; set; }
}
