using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiDotNet5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        ISaleService _saleService;

        public SalesController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public IActionResult Getall()
        {
            IDataResult<List<Sale>> get = _saleService.GetAll();
            if (get.Success)
            {
                return Ok(get);
            }
            return BadRequest(get);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            IDataResult<Sale> get = _saleService.GetById(id);
            if (get.Success)
            {
                return Ok(get);
            }
            return BadRequest(get);
        }

        [HttpPost]
        public IActionResult Add(Sale sale)
        {
            IResult get = _saleService.Add(sale);
            if (get.Success)
            {
                return Ok(get);
            }
            return BadRequest(get);
        }

        [HttpPut]
        public IActionResult Update(Sale sale)
        {
            IResult get = _saleService.Update(sale);
            if (get.Success)
            {
                return Ok(get);
            }
            return BadRequest(get);
        }

        [HttpDelete]
        public IActionResult Delete(Sale sale)
        {
            IResult get = _saleService.Delete(sale);
            if (get.Success)
            {
                return Ok(get);
            }
            return BadRequest(get);
        }

        [HttpPost("cancelSale")]
        public IActionResult CancelSale(Sale sale)
        {
            IResult get = _saleService.CancelSale(sale);
            if (get.Success)
            {
                return Ok(get);
            }
            return BadRequest(get);
        }
    }
}
