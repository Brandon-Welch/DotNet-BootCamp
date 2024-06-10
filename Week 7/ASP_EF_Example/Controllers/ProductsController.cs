using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Identity.Client;

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

         [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
                /* 
                EF does lazy loading, where if an entity contains another entity as a foreign key relationship
                EF will not load it (null value) unless you explicitly tell it to include it
                This is done to reduce unneccesary calls to the database from the API
                */
            IEnumerable<ProductDTO> products = _context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO
                    {
                        ProductId = p.ProductId,
                        Name = p.Name,
                        Price = p.Price,
                        CategoryName = p.Category.Name
                    }
                ).ToList();
            return Ok(products);
        }

        //POST: /Products
        // we expect them to provide a JSON body that matches our ProductDTO
        [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductDTO productDto)
        {
            //BC the Product entity contains the entity of Category, we need to include all the entitites in ours to be able to create the new entity
            //First we need to grab Category entitity, and since the ProductDTO only has the category name, that is the only way we can filter through the categories entity
            var category = _context.Categories.FirstOrDefault(c => c.Name == productDto.CategoryName);

            //We now need to check to see if the category name they proviuded actually exists
            //If the cateoery is null, then it means the catefgory does not exist and we can let them know its a bad request
            if (category == null)
            {
                return BadRequest($"Category {productDto.CategoryName} does not exist."); //string interpolation instead of concatenating the string
            }

            //if the category does exist, then we can use both the category entity and the productr DTO to create the product entity
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = category.CategoryId,
                Category = category
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, productDto);
        }

        //PUT (by ID) /Products/xx
        [HttpPut("id")]
        public IActionResult PutProduct(int id, ProductDTO productDto)
        {
            var product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == id);

            if(product == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Name == productDto.CategoryName);
            
            if(category == null)
            {
                return BadRequest($"Category {productDto.CategoryName} does not exist.");
            }

            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.CategoryId = category.CategoryId;
            product.Category = category;

            _context.Products.Update(product);
            _context.SaveChanges();

            return NoContent();
        }

        //PUT (by Name) /Products/xx
        [HttpPut]
        public IActionResult PutProductByName(ProductDTO productDto)
        {
            var product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Name == productDto.Name);

            if(product == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Name == productDto.CategoryName);
            
            if(category == null)
            {
                return BadRequest($"Category {productDto.CategoryName} does not exist.");
            }

            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.CategoryId = category.CategoryId;
            product.Category = category;

            _context.Products.Update(product);
            _context.SaveChanges();

            return NoContent();
        }

        //Delete /Products/Id
        [HttpDelete("id")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return NoContent();
        }


        /*
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
            var category = _context.Categories.FirstOrDefault(c=> c.Name == UpdatedProduct.CategoryName);
            

            product.Name = UpdatedProduct.Name;
            product.Price = UpdatedProduct.Price;
            product.Catetory = category;
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
        */
    }
}
