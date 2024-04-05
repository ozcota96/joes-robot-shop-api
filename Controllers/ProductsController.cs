using JoesRobotShopApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoesRobotShopApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetProducts()
        {
            return Ok(ProductsDataStore.Current.Products);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProduct(int id)
        {
            var productToReturn = ProductsDataStore.Current.Products
                .FirstOrDefault(p => p.Id == id);

            if (productToReturn == null)
            {
                return NotFound();
            }

            return Ok(productToReturn);
        }
    }
}