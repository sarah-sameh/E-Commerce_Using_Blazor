namespace BlazorApp1.RestfullServices
{
    public interface IService<T>
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task Update(int id, T Obj);

        Task Add(T Obj);

        Task Delete(int id);
    }
}
