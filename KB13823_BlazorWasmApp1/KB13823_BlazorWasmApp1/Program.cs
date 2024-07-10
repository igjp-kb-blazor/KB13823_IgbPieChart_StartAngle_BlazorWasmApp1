using IgniteUI.Blazor.Controls;
using KB13823_BlazorWasmApp1;
using KB13823_BlazorWasmApp1.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(typeof(IgbPieChartModule));
builder.Services.AddSingleton<EnergyGlobalDemandDataService>();

await builder.Build().RunAsync();
