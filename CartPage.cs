using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace SmartShopping.Mobile
{
    public class CartPage : ContentPage
    {
        ObservableCollection<string> items = new ObservableCollection<string>();

        public CartPage()
        {
            var list = new ListView { ItemsSource = items };
            Content = new StackLayout { Children = { new Label{ Text="Cart" }, list } };
            items.Add("Milk 1L - 5.0 SAR");
            items.Add("Bread - 2.5 SAR");
        }
    }
}
