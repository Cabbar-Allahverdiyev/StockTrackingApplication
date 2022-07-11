using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("getbybarcodenumber/{barcodeNumber}")]
        public IActionResult GetByBarcodeNumber(string barcodeNumber)
        {
            var result = _productService.GetByBarcodeNumber(barcodeNumber);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("productdetail")]
        public IActionResult GetAllProductDetail()
        {
            var result = _productService.GetAllProductDetail();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("productdetail/{productId}")]
        public IActionResult GetProductDetailById(int productId)
        {
            var result = _productService.GetProductDetailById(productId);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

    }
}
