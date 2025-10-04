using System;
using Xamarin.Forms;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartShopping.Mobile
{
    public class LoginPage : ContentPage
    {
        Entry emailEntry, passwordEntry;
        Button loginBtn;

        public LoginPage()
        {
            emailEntry = new Entry { Placeholder = "Email" };
            passwordEntry = new Entry { Placeholder = "Password", IsPassword = true };
            loginBtn = new Button { Text = "Login" };
            loginBtn.Clicked += LoginBtn_Clicked;

            Content = new StackLayout {
                Padding = 20,
                Children = { emailEntry, passwordEntry, loginBtn }
            };
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var payload = JsonSerializer.Serialize(new { email = emailEntry.Text, password = passwordEntry.Text });
            var res = await client.PostAsync("https://your-api.example.com/api/auth/login", new StringContent(payload, Encoding.UTF8, "application/json"));
            if (res.IsSuccessStatusCode) await DisplayAlert("OK","Logged in (demo)","Close");
            else await DisplayAlert("Error","Login failed","Close");
        }
    }
}
