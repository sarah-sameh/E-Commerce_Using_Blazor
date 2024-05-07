using BlazorApp1.Models;
using System.Net.Http.Json;

namespace BlazorApp1.RestfullServices
{
    public class ProductRestService : IService<Product>
    {
        HttpClient _httpClient;
        public ProductRestService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("http://localhost:5182/");
        }

        public async Task<List<Product>> GetAll()
        {
            List<Product> products = await _httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            Product product = await _httpClient.GetFromJsonAsync<Product>($"api/Product/{id}");
            return product;
        }

        public async Task Update(int id, Product product)
        {
            await _httpClient.PutAsJsonAsync<Product>($"api/Product/{id}", product);
        }

        public async Task Add(Product product)
        {
            await _httpClient.PostAsJsonAsync<Product>($"api/Product/", product);
        }
        public async Task Delete(int id)
        {
            await _httpClient.DeleteFromJsonAsync<Product>($"api/Product/{id}");
        }
    }
}
