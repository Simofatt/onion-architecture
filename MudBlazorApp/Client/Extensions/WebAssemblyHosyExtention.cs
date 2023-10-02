using Blazored.LocalStorage;
using ICSharpCode.Decompiler.CSharp.Syntax;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;

namespace MudBlazorApp.Client.Extensions
{
    public static class WebAssemblyHosyExtention
    {
        public async static Task SetDefaultCulture (this WebAssemblyHost host)
        {
            var localStorage = host.Services.GetRequiredService<ILocalStorageService>();
            var cultureFromLs = await localStorage.GetItemAsync<string>("culture");
            CultureInfo culture;
            if (cultureFromLs != null) {

                culture = new CultureInfo(cultureFromLs);

            }
            else
            {
                culture = new CultureInfo("fr-FR"); 
            }
            CultureInfo.DefaultThreadCurrentCulture = culture; 
            CultureInfo.DefaultThreadCurrentUICulture = culture;    

        }
    }
}
