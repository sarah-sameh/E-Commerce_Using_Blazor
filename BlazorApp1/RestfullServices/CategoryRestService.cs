using BlazorApp1.Models;
using System.Net.Http.Json;

namespace BlazorApp1.RestfullServices
{
    public class CategoryRestService : IService<Category>
    {

        HttpClient _httpClient;

        public CategoryRestService(HttpClient httpClient)
        {
            _httpClient = httpClient;


            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("http://localhost:5182/");
        }

        async Task<List<Category>> IService<Category>.GetAll()
        {
            var cat = await _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
            return cat;
        }


        Task IService<Category>.Add(Category Obj)
        {
            throw new NotImplementedException();
        }

        Task IService<Category>.Delete(int id)
        {
            throw new NotImplementedException();
        }



        Task<Category> IService<Category>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task IService<Category>.Update(int id, Category Obj)
        {
            throw new NotImplementedException();
        }

    }
}
