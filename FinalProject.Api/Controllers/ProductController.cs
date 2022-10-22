using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TiendasyCompras.Queries.Product;
using TiendasyCompras.Repository.Product;

namespace TiendasyCompras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductQueries _productQueries;

        public ProductController(IProductRepository productRepository, IProductQueries productQueries)
        {
            _productRepository = productRepository;
            _productQueries = productQueries;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetById([FromRoute] int id)
        {
            var result = await _productQueries.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productQueries.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Model.Product product)
        {
            var result = await _productRepository.Create(product);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Model.Product product)
        {
            var result = await _productRepository.Update(product);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var result = await _productRepository.Delete(id);
            return Ok(result);
        }
    }
}
