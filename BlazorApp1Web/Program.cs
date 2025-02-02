using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using DataAccessHandler;
//using BusinessLogicProcessor;
using System.Net.Http;
using BlazorApp1Web;
using BlazorApp1Web.data.ReadWrite;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//DI CONTAINER{
    // Register HttpClient for API calls
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Register services
builder.Services.AddScoped<ReadWrite>();

// Register JsonFileHandling with the file path "Data/questions.json"
//builder.Services.AddScoped(sp => new JsonFileHandling("Data/questions.json"));

// Register QuestionProcessor with the DI container
//builder.Services.AddScoped<QuestionProcessor>();

//}

await builder.Build().RunAsync();
