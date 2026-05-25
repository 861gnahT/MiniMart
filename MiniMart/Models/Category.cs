using MiniMart.Models.Base;

namespace MiniMart.Models
{
    public class Category : BaseEntity
    {
        public int CategoryId { get; set; }

        public string CategoryCode { get; set; }

        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public bool Status { get; set; }

        public int DisplayOrder { get; set; }

        public int? ParentCategoryId { get; set; }

        public Category? ParentCategory { get; set; }

        public ICollection<Category> ChildCategories { get; set; }
            = new List<Category>();

        public ICollection<Product> Products { get; set; }
            = new List<Product>();
    }
}