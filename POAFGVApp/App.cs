using System;
using Prism.Unity;
using Xamarin.Forms.Xaml;
using POAFGVApp.Views;
using POAFGVApp.Infrastructure.Repositories;
using Microsoft.Practices.Unity;
using POAFGVApp.ApplicationServices;
using Xamarin.Forms;

namespace POAFGVApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class App : PrismApplication
    {
        public static SQLite.SQLiteConnection AppSQLiteConn { get; set; }

        protected override void OnInitialized()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterTypes()
        {
            //registrar Views para navegação
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<NavigationPage>();

            //Registrando IoC - Injeção de dependencia
            Container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<>), new ContainerControlledLifetimeManager());
            Container.RegisterType(typeof(IBaseApplicationService<>), typeof(BaseApplicationService<>), new ContainerControlledLifetimeManager());
        }
    }
}
