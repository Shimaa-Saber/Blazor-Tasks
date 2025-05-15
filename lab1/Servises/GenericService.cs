namespace lab1.Servises
{
    public interface GenericService<T>
    {
        List<T> GetAll();
        T GetByID(int id);
    }
}
