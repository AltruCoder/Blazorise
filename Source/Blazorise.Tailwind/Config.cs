#region Using directives
using System;
using Microsoft.Extensions.DependencyInjection;
#endregion

namespace Blazorise.Tailwind
{
    public static class Config
    {
        /// <summary>
        /// Adds tailwind design providers and component mappings.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <returns></returns>
        public static IServiceCollection AddTailwindProviders( this IServiceCollection serviceCollection, Action<IClassProvider> configureClassProvider = null )
        {
            var classProvider = new TailwindClassProvider();

            configureClassProvider?.Invoke( classProvider );

            serviceCollection.AddSingleton<IClassProvider>( classProvider );
            serviceCollection.AddSingleton<IStyleProvider, TailwindStyleProvider>();
            serviceCollection.AddScoped<IJSRunner, TailwindJSRunner>();
            serviceCollection.AddSingleton<IComponentMapper, ComponentMapper>();
            serviceCollection.AddScoped<IThemeGenerator, TailwindThemeGenerator>();

            return serviceCollection;
        }

        private static void RegisterComponents( IComponentMapper componentMapper )
        {
            //componentMapper.Register<Blazorise.Addons, Tailwind.Addons>();
            //componentMapper.Register<Blazorise.Addon, Tailwind.Addon>();
            //componentMapper.Register<Blazorise.AddonLabel, Tailwind.AddonLabel>();
            //componentMapper.Register<Blazorise.AlertMessage, Tailwind.AlertMessage>();
            //componentMapper.Register<Blazorise.AlertDescription, Tailwind.AlertDescription>();
            //componentMapper.Register<Blazorise.Badge, Tailwind.Badge>();
            //componentMapper.Register<Blazorise.Bar, Tailwind.Bar>();
            //componentMapper.Register<Blazorise.BarBrand, Tailwind.BarBrand>();
            //componentMapper.Register<Blazorise.BarIcon, Tailwind.BarIcon>();
            //componentMapper.Register<Blazorise.BarItem, Tailwind.BarItem>();
            //componentMapper.Register<Blazorise.BarMenu, Tailwind.BarMenu>();
            //componentMapper.Register<Blazorise.BarStart, Tailwind.BarStart>();
            //componentMapper.Register<Blazorise.BarEnd, Tailwind.BarEnd>();
            componentMapper.Register<Blazorise.BarDropdown, Tailwind.BarDropdown>();
            //componentMapper.Register<Blazorise.BarLink, Tailwind.BarLink>();
            //componentMapper.Register<Blazorise.BarDropdownMenu, Tailwind.BarDropdownMenu>();
            //componentMapper.Register<Blazorise.BarDropdownItem, Tailwind.BarDropdownItem>();
            //componentMapper.Register<Blazorise.BarDropdownToggle, Tailwind.BarDropdownToggle>();
            componentMapper.Register<Blazorise.BarToggler, Tailwind.BarToggler>();
            //componentMapper.Register<Blazorise.Breadcrumb, Tailwind.Breadcrumb>();
            //componentMapper.Register<Blazorise.BreadcrumbItem, Tailwind.BreadcrumbItem>();
            //componentMapper.Register<Blazorise.BreadcrumbLink, Tailwind.BreadcrumbLink>();
            //componentMapper.Register( typeof( Blazorise.Check<> ), typeof( Tailwind.Check<> ) );
            componentMapper.Register<Blazorise.Button, Tailwind.Button>();
            //componentMapper.Register<Blazorise.CardHeader, Tailwind.CardHeader>();
            //componentMapper.Register<Blazorise.CardLink, Tailwind.CardLink>();
            //componentMapper.Register<Blazorise.Carousel, Tailwind.Carousel>();
            //componentMapper.Register<Blazorise.CloseButton, Tailwind.CloseButton>();
            //componentMapper.Register<Blazorise.CollapseHeader, Tailwind.CollapseHeader>();
            //componentMapper.Register<Blazorise.Dropdown, Tailwind.Dropdown>();
            //componentMapper.Register<Blazorise.DropdownMenu, Tailwind.DropdownMenu>();
            //componentMapper.Register<Blazorise.DropdownItem, Tailwind.DropdownItem>();
            componentMapper.Register<Blazorise.DropdownToggle, Tailwind.DropdownToggle>();
            //componentMapper.Register<Blazorise.Field, Tailwind.Field>();
            //componentMapper.Register<Blazorise.FieldBody, Tailwind.FieldBody>();
            //componentMapper.Register<Blazorise.FieldLabel, Tailwind.FieldLabel>();
            //componentMapper.Register<Blazorise.FileEdit, Tailwind.FileEdit>();
            //componentMapper.Register<Blazorise.ListGroup, Tailwind.ListGroup>();
            //componentMapper.Register<Blazorise.ModalBackdrop, Tailwind.ModalBackdrop>();
            //componentMapper.Register<Blazorise.ModalContent, Tailwind.ModalContent>();
            //componentMapper.Register<Blazorise.Progress, Tailwind.Progress>();
            //componentMapper.Register( typeof( Blazorise.Select<> ), typeof( Tailwind.Select<> ) );
            //componentMapper.Register( typeof( Blazorise.SelectItem<> ), typeof( Tailwind.SelectItem<> ) );
            //componentMapper.Register<Blazorise.SelectGroup, Tailwind.SelectGroup>();
            //componentMapper.Register( typeof( Blazorise.Radio<> ), typeof( Tailwind.Radio<> ) );
            //componentMapper.Register( typeof( Blazorise.Slider<> ), typeof( Tailwind.Slider<> ) );
            //componentMapper.Register( typeof( Blazorise.Switch<> ), typeof( Tailwind.Switch<> ) );
            //componentMapper.Register<Blazorise.Tabs, Tailwind.Tabs>();
            //componentMapper.Register<Blazorise.Tab, Tailwind.Tab>();
            //componentMapper.Register<Blazorise.TabPanel, Tailwind.TabPanel>();
            //componentMapper.Register<Blazorise.TabsContent, Tailwind.TabsContent>();
            //componentMapper.Register<Blazorise.Table, Tailwind.Table>();
            //componentMapper.Register<Blazorise.TableRowHeader, Tailwind.TableRowHeader>();
            //componentMapper.Register<Blazorise.TextEdit, Tailwind.TextEdit>();
        }

        /// <summary>
        /// Registers the custom rules for ant design components.
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IServiceProvider UseTailwindProviders( this IServiceProvider serviceProvider )
        {
            var componentMapper = serviceProvider.GetRequiredService<IComponentMapper>();

            RegisterComponents( componentMapper );

            return serviceProvider;
        }
    }
}

