using Microsoft.EntityFrameworkCore;

namespace Study_project.work_with_ORM.models
{
    internal class ORM
    {
        private protected contextDB context;
        private static ORM? instance;
        private ORM() 
        {
            context = new contextDB();
            context.Database.EnsureCreated();
        }
        public static ORM setInstance()
        {
            if (instance == null)
            {
                instance = new ORM();
            }
            return instance;
        }
        public void showAllProductForCategories()
        {
            var categories = this.context.Categories.Include(c => c.Products).ToList();
            foreach (var c in categories)
            {
                Console.WriteLine($"Category:   {c.Name}");
                foreach (var p in c.Products)
                {
                    Console.WriteLine($"    Product:    {p.Name} - {p.Price}");
                }
            }
        }
        public void createCategory(CategoryModel newCategory)
        {
            try
            {
                this.context.Categories.Add(newCategory);
                context.SaveChanges();
                Console.WriteLine($"added new category {newCategory.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public void createCategory(string categoryName)
        {
            this.createCategory(new CategoryModel { Name = categoryName });
        }
        public void updateCategory(string categoryName, string categoryNewName)
        {
            var categoryToUpdate = this.context.Categories.FirstOrDefault(c => c.Name == categoryName);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = categoryNewName;
                context.SaveChanges();
                Console.WriteLine($"updated category {categoryName} to {categoryNewName}");
            }
            else
            {
                Console.WriteLine($"ERROR: can`t find category {categoryName}");
            }
        }
        public void deleteCategory(CategoryModel categoryToDelete)
        {
            var categoryToDeleteWithData = context.Categories.Include(c => c.Products).FirstOrDefault(c => c.Name == categoryToDelete.Name);
            context.Categories.Remove(categoryToDeleteWithData);
            context.SaveChanges();
            Console.WriteLine($"Category {categoryToDelete.Name} and their products deleted!");
        }
        public void deleteCategory(string categoryName)
        {
            var categoryToDelete = context.Categories.FirstOrDefault(c => c.Name == categoryName);
            if (categoryToDelete != null)
            {
                this.deleteCategory(categoryToDelete);
            }
            else
            {
                Console.WriteLine($"ERROR: can`t find category {categoryName}");
            }
        }
        public void createProduct(CategoryModel category, string name, float price=0)
        {
            this.createProduct(new ProductModel { Name = name, Price = price, Category = category });
        }
        public void createProduct(ProductModel newProduct)
        {
            try
            {
                this.context.Products.Add(newProduct);
                context.SaveChanges();
                Console.WriteLine($"added new product {newProduct.Name} to category {newProduct.Category.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public void updateProduct(ProductModel product, string productNewName)
        {
            var productToUpdate = this.context.Products.FirstOrDefault(p => p.Name == product.Name);
            if (productToUpdate != null)
            {
                productToUpdate.Name = productNewName;
                context.SaveChanges();
                Console.WriteLine($"updated product {product.Name} name to {productNewName}");
            }
            else
            {
                Console.WriteLine($"ERROR: can`t find category {product.Name}");
            }
        }
        public void updateProduct(ProductModel product, float productNewPrice)
        {
            var productToUpdate = this.context.Products.FirstOrDefault(p => p.Name == product.Name);
            if (productToUpdate != null)
            {
                productToUpdate.Price = productNewPrice;
                context.SaveChanges();
                Console.WriteLine($"updated product {product.Name} price to {productNewPrice}");
            }
            else
            {
                Console.WriteLine($"ERROR: can`t find category {product.Name}");
            }
        }
        public void updateProduct(ProductModel product, string productNewName, float productNewPrice)
        {
            var productToUpdate = this.context.Products.FirstOrDefault(p => p.Name == product.Name);
            if (productToUpdate != null)
            {
                productToUpdate.Price = productNewPrice;
                productToUpdate.Name= productNewName;
                context.SaveChanges();
                Console.WriteLine($"updated product {product.Name} name to {productNewName} price to {productNewPrice}");
            }
            else
            {
                Console.WriteLine($"ERROR: can`t find category {product.Name}");
            }
        }
        public void deleteProduct(ProductModel productModel)
        {
            try
            {
                this.context.Remove(productModel);
                context.SaveChanges();
                Console.WriteLine($"deleted product {productModel.Name} from category {productModel.Category.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public void deleteProduct(string productToDeleteName)
        {
            var productToDelete = this.context.Products.FirstOrDefault(p => p.Name == productToDeleteName);
            if (productToDelete != null)
            {
                this.deleteProduct(productToDelete);
            }
            else
            {
                Console.WriteLine($"ERROR: can`t find product {productToDeleteName}");
            }
        }
    }
}
