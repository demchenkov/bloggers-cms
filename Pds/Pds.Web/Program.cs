﻿global using Newtonsoft.Json;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Pds.Web;
using Pds.Web.Common;
using Pds.Web.Common.AppStart;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IApiClient, ApiClient>();
builder.Services.AddSingleton<StateContainer>();
builder.Services.AddSingleton<PageHistoryState>();
builder.Services.AddHeadElementHelper();
builder.Services.AddCustomAutoMapper();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddCustomAuthentication(builder.Configuration);

await builder.Build().RunAsync();

