using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Costea_Cosmina_lab12.Services;
using Costea_Cosmina_lab12.Views;
using Costea_Cosmina_lab12.Data;

namespace Costea_Cosmina_lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
