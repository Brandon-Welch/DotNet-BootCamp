using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        //Get All Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = p.Category.Name
                }).ToList();

            return products;
        }

        //Get Product by ID
        [HttpGet("{ProductId}")]
        public ActionResult<ProductDTO> GetProductById(int ProductId)
        {
            //var product = _context.Products.Find(ProductId);
            var product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == ProductId);
            var productDto = new ProductDTO{
                Name = product.Name,
                Price = product.Price,
                CategoryName = product.Category.Name
            };
            return productDto;
        }

        //Add Product
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> PostProduct(ProductDTO productDto)
        {
            var category = await _context.Categories.FirstAsync(c => c.Name == productDto.CategoryName);

            
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = category.CategoryId,
                Category = category
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProducts), new { ProductId = product.ProductId }, productDto);
        }
        
        //Update Product
        [HttpPut("{ProductId}")]
        public ActionResult<ProductDTO> UpdateProduct(int ProductId, ProductDTO UpdatedProduct)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            

            product.Name = UpdatedProduct.Name;
            product.Price = UpdatedProduct.Price;
            //product.CategoryName = UpdatedProduct.CategoryName;
            //product.CategoryId = UpdatedProduct.CategoryId;
            //product.Category = UpdatedProduct.Category;
            //TODO: do we need more updates? price? CategoryName?

            _context.Products.Update(product);
            _context.SaveChanges();

            return Ok(UpdatedProduct);
        }

        //Delete Product
        [HttpDelete("{ProductId}")]
        public IActionResult DeleteProduct(int ProductId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }
    }
}
