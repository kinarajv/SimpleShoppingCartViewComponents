using Microsoft.AspNetCore.Mvc;
using ShoppingCartSample.ViewComponents.ViewModel;
using SimpleShoppingCart.Services;

namespace ShoppingCartSample.ViewComponents
{
  public class ShoppingCartViewComponent : ViewComponent
  {
    private readonly CartService _cartService;
    
    public ShoppingCartViewComponent(CartService cartService)
    {
      _cartService = cartService;
    }
    
    public IViewComponentResult Invoke()
    {
      var cartItems = _cartService.GetCartItems();
      var total = _cartService.GetTotal();
      var count = cartItems.Count;
    
      var model = new ShoppingCartViewModel
      {
        Items = cartItems,
        Total = total,
        ItemCount = count
      };
    
      return View(model);
    }
  }
}