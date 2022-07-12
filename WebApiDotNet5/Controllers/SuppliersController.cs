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
    public class SuppliersController : ControllerBase
    {
        ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost]
        public IActionResult Add(Supplier supplier)
        {
            IResult result = _supplierService.Add(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Supplier supplier)
        {
            IResult result = _supplierService.Update(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Supplier supplier)
        {
            IResult result = _supplierService.Delete(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IDataResult<List<Supplier>> result = _supplierService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            IDataResult<Supplier> result = _supplierService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("GetAllByCompanyName{companyName}")]
        public IActionResult GetAllByCompanyName(string companyName)
        {
            IDataResult<List<Supplier>> result = _supplierService.GetAllByCompanyName(companyName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("GetAllByContactName{contactName}")]
        public IActionResult GetAllByContactName(string contactName)
        {
            IDataResult<List<Supplier>> result = _supplierService.GetAllByContactName(contactName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
