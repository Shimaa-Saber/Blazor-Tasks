using lab1.Models;

namespace lab1.Pages
{
    public partial class  ProductComponent
    {
        public Product product { get; set; }

        public int ProductId { get; set; }

        public List<Product> ProdList { get; set; }

        public ProductComponent()
        {
            ProdList = new List<Product>();

            ProdList.Add(new Product() { id = 1, Name = "Lab", Price = 2000, ImageURl = "images/lab.jpeg" });
            ProdList.Add(new Product() { id = 2, Name = "headphone", Price = 4000, ImageURl = "images/head.jpeg" });
            ProdList.Add(new Product() { id = 3, Name = "phone", Price = 5000, ImageURl = "images/phone.jpeg" });
            ProdList.Add(new Product() { id = 4, Name = "mac", Price = 7000, ImageURl = "images/mac.jpeg" });
        }

        public void GetPro()
        {
            product = ProdList.FirstOrDefault(p => p.id == ProductId);
        }
    }

 }

