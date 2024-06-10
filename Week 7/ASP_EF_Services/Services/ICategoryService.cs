using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    /*
        We use an interface because the Dependency Injection (DI) container prefers having the most generic version of the dependency to work with.
        The DI container will look for any instances of this interface and use the provided implementation to inject it where it is needed.

        An interface is a contract for a class. It lays out the required methods that any class must implement if it chooses to use the interface.
    */
    public interface ICategoryService
    {
        // Method to get a list of all Categories
        IEnumerable<CategoryDTO> GetAllCategories();

        // Method to get a specific Category by their ID
        CategoryDTO GetCategoryById(int CategoryId);

        // Method to create a new Category based on the provided CategoryDTO
        Category CreateCategory(CategoryDTO CategoryDto);

        // Method to update an existing Category based on their ID and the provided updated CategoryDTO
        void UpdateCategory(int CategoryId, CategoryDTO UpdatedCategory);

        // Method to delete a Category based on their ID
        void DeleteCategory(int CategoryId);
    }
}
