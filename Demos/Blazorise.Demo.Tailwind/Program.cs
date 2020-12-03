#region Using directives
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazorise.Tailwind;
using Blazorise.RichTextEdit;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazorise.Icons.FontAwesome;
#endregion

namespace Blazorise.Demo.Tailwind
{
    public class Program
    {
        public static async Task Main( string[] args )
        {
            var builder = WebAssemblyHostBuilder.CreateDefault( args );

            builder.Services
                .AddBlazorise( options =>
                {
                    options.ChangeTextOnKeyPress = true;
                } )
                .AddBlazoriseRichTextEdit( options =>
                {
                    options.UseBubbleTheme = true;
                    options.UseShowTheme = true;
                } )
                .AddTailwindProviders()
                .AddFontAwesomeIcons();

            builder.Services.AddSingleton( new HttpClient
            {
                BaseAddress = new Uri( builder.HostEnvironment.BaseAddress )
            } );

            builder.RootComponents.Add<App>( "#app" );

            var host = builder.Build();

            host.Services
                .UseTailwindProviders()
                .UseFontAwesomeIcons();

            await host.RunAsync();
        }
    }
}
