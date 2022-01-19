using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        [HttpGet]
        public List<Product> get()
        {
            return productManager.GetAll();
        }
    }
}
