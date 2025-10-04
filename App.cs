using Xamarin.Forms;

namespace SmartShopping.Mobile
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
