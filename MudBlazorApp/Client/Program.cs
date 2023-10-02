using Application.Interfaces.Repositories;
using Blazored.LocalStorage;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using MudBlazor;
using MudBlazor.Services;
using MudBlazorApp.Client;
using MudBlazorApp.Client.Extensions;
using Synaplic.UniRH.Client;
using Synaplic.UniRH.Client.Infrastructure.ApiClients;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddDbContext<AuditableContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefautlConnection")));
builder.Services.AddMudServices();
builder.Services.AddTransient<IUnitOfWork<int>, UnitOfWork<int>>();
//LOCALIZER 





//builder.Services.AddSingleton<FrontEndLocalizer>();
//builder.Services.AddSingleton<IStringLocalizer>(sp => sp.GetRequiredService<IStringLocalizer<FrontEndLocalizer>>());
//builder.Services.AddScoped<RequestLocalizationCookiesMiddleware>();

builder.Services.AddHttpClient();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
    config.SnackbarConfiguration.PreventDuplicates = true;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddLocalization();
builder.Services
               .AddLocalization(options =>
               {
                  // options.ResourcesPath = "Resources";   //configure the path to the resx files 
               })
               .Configure<RequestLocalizationOptions>(options =>
               {
                   List<CultureInfo> supportedCultures = new List<CultureInfo>
                   {
                        new CultureInfo("es-ES"),
                        new CultureInfo("fr-FR")
                   };
                   options.DefaultRequestCulture = new RequestCulture("fr-FR");
                   options.SupportedCultures = supportedCultures;
                   options.SupportedUICultures = supportedCultures;
                   // options.RequestCultureProviders.Remove((IRequestCultureProvider)typeof(AcceptLanguageHeaderRequestCultureProvider));     // i want the user to change their culture not via http headers
               });
builder.Services.AddBlazoredLocalStorage();



// Configure other Services
var host = builder.Build();
await host.SetDefaultCulture();
await host.RunAsync();