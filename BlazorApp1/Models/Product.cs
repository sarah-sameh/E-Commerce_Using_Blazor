using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Product
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name Must be More than 2 char")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1000, 150000, ErrorMessage = "Price must be between 1000 and 150000")]
        public int? Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { set; get; }

        [Required(ErrorMessage = "Image URL is required")]
        public string? Image { set; get; }
        public int CatId { get; set; }

    }
}
