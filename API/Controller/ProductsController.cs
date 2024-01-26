using System;
using API.DATA;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _Context;
       
        public ProductsController(StoreContext Context)
        {
            _Context = Context;
             
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
             return await _Context.products.ToListAsync();   
        }
        
        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _Context.products.FindAsync(id);
        }
            }
}