namespace SimpleShoppingCart.Models;

public class CartViewModel
{
  public List<CartItem> Items { get; set; }
  public decimal Total { get; set; }
}
