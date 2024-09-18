using Microsoft.AspNetCore.Mvc;
using SimpleShoppingCart.Services;

namespace ShoppingCartSample.Controllers
{
  public class ProductController : Controller
  {
    private readonly ProductService _productService;
    private readonly CartService _cartService;
    
    public ProductController(ProductService productService, CartService cartService)
    {
      _productService = productService;
      _cartService = cartService;
    }
    
    public IActionResult Index()
    {
      var products = _productService.GetAllProducts();
      return View(products);
    }
    
    [HttpPost]
    public IActionResult AddToCart(int id, int quantity = 1)
    {
      var product = _productService.GetProductById(id);
      if (product == null)
      {
        return NotFound();
      }
    
      _cartService.AddToCart(product, quantity);
      return RedirectToAction("Index");
    }
  }
}