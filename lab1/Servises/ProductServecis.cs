using lab1.Models;

namespace lab1.Servises
{
    public class ProductServecis:IProduct

    {
        List<Product> products;
        public ProductServecis()
        {
            products = new List<Product>();
            products.Add(new Product() { id = 1, Name = "Lab", Price = 2000, ImageURl = "images/lab.jpeg",Category_id=1 });
            products.Add(new Product() { id = 2, Name = "headphone", Price = 4000, ImageURl = "images/head.jpeg", Category_id = 1 });
            products.Add(new Product() { id = 3, Name = "phone", Price = 5000, ImageURl = "images/phone.jpeg", Category_id = 2 });
            products.Add(new Product() { id = 4, Name = "mac", Price = 7000, ImageURl = "images/mac.jpeg", Category_id = 3 });
        }
        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetByID(int id)
        {
            return products.FirstOrDefault(p => p.id == id);
        }

    }
}
