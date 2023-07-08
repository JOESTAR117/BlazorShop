using BlazorShop.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseURL = "https://localhost:7118";

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(baseURL) 
});

await builder.Build().RunAsync();
