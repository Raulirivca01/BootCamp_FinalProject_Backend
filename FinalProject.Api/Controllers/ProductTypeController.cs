using Microsoft.AspNetCore.Mvc;
using TiendasyComprasViewModel.Queries.ProductType;

namespace TiendasyCompras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeQueries _productTypeQueries;

        public ProductTypeController(IProductTypeQueries productTypeQueries)
        {
            _productTypeQueries = productTypeQueries ?? throw new ArgumentNullException(nameof(productTypeQueries)); ;
        }


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productTypeQueries.GetAll();
            return Ok(result);
        }
    }
}
