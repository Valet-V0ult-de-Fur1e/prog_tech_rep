using System.ComponentModel.DataAnnotations.Schema;
namespace Study_project.work_with_ORM.models
{
    [Table("catalog.products")]
    public class ProductModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public float Price { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
