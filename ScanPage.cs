using System;
using Xamarin.Forms;

namespace SmartShopping.Mobile
{
    public class ScanPage : ContentPage
    {
        public ScanPage()
        {
            var label = new Label { Text = "Barcode / QR scanner placeholder (use ZXing)" };
            Content = new StackLayout { Children = { label } };
        }
    }
}
