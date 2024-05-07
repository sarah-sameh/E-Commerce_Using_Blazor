using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class CategoryService
    {
        private List<Category> categories;

        public CategoryService()
        {
            // Initialize the list of categories
            categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothes" },
                // Add more categories here if needed
            };
        }

        public List<Category> GetAllCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public string GetCategoryName(int categoryId)
        {
            var category = categories.FirstOrDefault(c => c.Id == categoryId);
            return category.Name;
        }
    }


}
