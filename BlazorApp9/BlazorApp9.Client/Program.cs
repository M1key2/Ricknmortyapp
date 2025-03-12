using BlazorApp9.Client.Pages;
using BlazorApp9.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Radzen;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddHttpClient<RickAndMortyService>(client =>
{
    client.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
});
builder.Services.AddRadzenComponents();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<CharacterDialog>();
builder.Services.AddScoped<DialogService>();


await builder.Build().RunAsync();
