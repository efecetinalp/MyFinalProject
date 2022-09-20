using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            return new List<Product> { 
                new Product { ProductId=1, CategoryId=1, ProductName ="product1", UnitPrice = 22},
                new Product{ ProductId=2, CategoryId=2, ProductName ="product2", UnitPrice=33}};
        }
    }
}
