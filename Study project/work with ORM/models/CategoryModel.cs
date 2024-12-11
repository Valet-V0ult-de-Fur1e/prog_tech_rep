using System.ComponentModel.DataAnnotations.Schema;
namespace Study_project.work_with_ORM.models
{
    [Table("catalog.categories")]
    public class CategoryModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        public List<ProductModel> Products { get; set; } = new();
    }
}
