using BlazorApp1.Models;
using BlazorApp1.RestfullServices;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("IP")) });

            builder.Services.AddScoped<ProductService>();
            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<ProductRestService>();
            builder.Services.AddScoped<IService<Product>, ProductRestService>();
            builder.Services.AddScoped<IService<Category>, CategoryRestService>();

            await builder.Build().RunAsync();
        }
    }
}
