using Microsoft.AspNetCore.Mvc;
using ShoppingCartSample.ViewComponents.ViewModel;
using SimpleShoppingCart.Services;

namespace ShoppingCartSample.Controllers
{
  public class CartController : Controller
  {
    private readonly CartService _cartService;
    
    public CartController(CartService cartService)
    {
      _cartService = cartService;
    }
    
    public IActionResult Index()
    {
      var cartItems = _cartService.GetCartItems();
      var total = _cartService.GetTotal();
      var model = new CartViewModel
      {
        Items = cartItems,
        Total = total
      };
      return View(model);
    }
    
    [HttpPost]
    public IActionResult Update(int productId, int quantity)
    {
      _cartService.UpdateCartItem(productId, quantity);
      return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult Remove(int productId)
    {
      _cartService.RemoveFromCart(productId);
      return RedirectToAction("Index");
    }
  }
}