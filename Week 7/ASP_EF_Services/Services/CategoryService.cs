using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Services
{
    /*
        The service class implements the IUserService interface.
        This means that all the declared methods in the interface must have some kind of implementation inside the service class.

        We are also using dependency injection to have access to the database context.

        Most of the core methods inside the service will just be moving the operations that were happening inside the controller endpoints into the service methods.

        Additional validations and checks are added to improve the stability of your application, such as:
        - Validating if the new data is in the right format.
        - Handling cases where an ID is provided for a user that doesn't exist.
        - Incorporating null checks in your service layer.
    */
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        // Constructor to inject the database context
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        // Method to create a new category based on the provided CategoryDTO
        public Category CreateCategory(CategoryDTO CategoryDto)
        {
            if (ValidateNewCategory(CategoryDto))
            {
                var category = new Category
                {
                    Name = CategoryDto.Name,
                    Products = []
                };

                _context.Categories.Add(category);
                _context.SaveChanges();

                return category;
            }
            else
            {
                throw new Exception("Invalid Category");
            }
        }  

        // Method to get a list of all categories
        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            var categories = _context.Categories
                .Include(c => c.Products)
                .Select(c => new CategoryDTO
                {
                    Name = c.Name
                }).ToList();

            return categories;
        }

        // Method to get a specific category by their ID
        public CategoryDTO GetCategoryById(int CategoryId)
        {
            var category = _context.Categories.Find(CategoryId);

            if (category != null)
            {
                var categoryDto = new CategoryDTO
                {
                    Name = category.Name,
                };

                return categoryDto;
            }
            else
            {
                throw new Exception("Category not found");
            }
        }

        // Method to update an existing category based on their ID and the provided updated CategoryDTO
        public void UpdateCategory(int CategoryId, CategoryDTO UpdatedCategory)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);

            if (category != null)
            {
                category.Name = UpdatedCategory.Name;

                _context.Categories.Update(category);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Category not found");
            }
        }

        // Method to delete a category based on their ID
        public void DeleteCategory(int CategoryId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);

            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Category not found");
            }
        }

        // Private Helper method to validate the new category data
        private bool ValidateNewCategory(CategoryDTO CategoryDto)
        {
            return !string.IsNullOrWhiteSpace(CategoryDto.Name);
        }

    }
}
