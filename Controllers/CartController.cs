using JoesRobotShopApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoesRobotShopApi.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private List<ProductDto> Cart { get; set; }

        public CartController()
        {
            Cart = new List<ProductDto>();
        }

        [HttpGet]
        public ActionResult GetCart()
        {
            return Ok(Cart);
        }

        [HttpPost]
        public ActionResult AddToCart(IEnumerable<ProductDto> products)
        {
            Cart.AddRange(products);
            return Created();
        }
    }
}