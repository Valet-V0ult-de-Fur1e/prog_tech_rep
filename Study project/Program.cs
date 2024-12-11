using Study_project.work_with_ORM.models;

namespace Study_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ORM db = ORM.setInstance();
            CategoryModel bikesCategory = new CategoryModel { Name = "bikes" };
            db.createCategory(bikesCategory);
            ProductModel bike1 = new ProductModel { Name = "stels navigator black", Price = 20000, Category = bikesCategory };
            db.createProduct(bike1);
            db.showAllProductForCategories();
            db.updateCategory("bikes", "black bikes");
            db.showAllProductForCategories();
            db.deleteCategory(bikesCategory);
        }
    }
}