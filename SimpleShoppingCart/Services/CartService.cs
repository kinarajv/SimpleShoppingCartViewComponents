using Newtonsoft.Json;
using SimpleShoppingCart.Models;

namespace SimpleShoppingCart.Services;

public class CartService 
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string CartCookieName = "Cart";
    
        public CartService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    
        public List<CartItem> GetCartItems()
        {
            var context = _httpContextAccessor.HttpContext;
            var cookie = context.Request.Cookies[CartCookieName];
            if (string.IsNullOrEmpty(cookie))
            {
                return new List<CartItem>();
            }
    
            return JsonConvert.DeserializeObject<List<CartItem>>(cookie) ?? new List<CartItem>();
        }
    
        public void AddToCart(Product product, int quantity)
        {
            var cart = GetCartItems();
            var existingItem = cart.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cart.Add(new CartItem { Product = product, Quantity = quantity });
            }
            SaveCart(cart);
        }
    
        public void RemoveFromCart(int productId)
        {
            var cart = GetCartItems();
            var item = cart.FirstOrDefault(ci => ci.Product.Id == productId);
            if (item != null)
            {
                cart.Remove(item);
                SaveCart(cart);
            }
        }
    
        public void UpdateCartItem(int productId, int quantity)
        {
            var cart = GetCartItems();
            var item = cart.FirstOrDefault(ci => ci.Product.Id == productId);
            if (item != null)
            {
                item.Quantity = quantity;
                if (item.Quantity <= 0)
                {
                    cart.Remove(item);
                }
                SaveCart(cart);
            }
        }
    
        public decimal GetTotal()
        {
            var cart = GetCartItems();
            return cart.Sum(ci => ci.Product.Price * ci.Quantity);
        }
    
        private void SaveCart(List<CartItem> cart)
        {
            var context = _httpContextAccessor.HttpContext;
            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7),
                HttpOnly = true,
                IsEssential = true
            };
            var json = JsonConvert.SerializeObject(cart);
            context.Response.Cookies.Append(CartCookieName, json, options);
        }
    }
