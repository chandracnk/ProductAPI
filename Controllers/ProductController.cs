using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet("query")]
        public IActionResult QueryProducts([FromQuery] string query)
        {
            var result = _service.QueryProducts(query);
            return Ok(result);
        }
    }
}
