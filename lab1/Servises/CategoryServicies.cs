using lab1.Models;

namespace lab1.Servises
{
    public class CategoryServicies:ICategory
    {
        List<Category> categories;
        public CategoryServicies()
        {
            categories = new List<Category>();
            categories.Add(new Category() { id = 1, Name = "Electronics" });
            categories.Add(new Category() { id = 2, Name = "Sports", });
            categories.Add(new Category() { id = 3, Name = "Food" });
           
        }
        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetByID(int id)
        {
            return categories.FirstOrDefault(c => c.id == id);
        }
    }
}
