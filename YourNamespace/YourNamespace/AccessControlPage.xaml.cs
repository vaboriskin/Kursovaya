using System;
using Xamarin.Forms;

namespace YourNamespace
{
    public partial class AccessControlPage : ContentPage
    {
        public AccessControlPage()
        {
            InitializeComponent();
        }

        private void OnCheckAccessClicked(object sender, EventArgs e)
        {
            string visitorId = VisitorIdEntry.Text;

            if (string.IsNullOrEmpty(visitorId))
            {
                DisplayAlert("Ошибка", "Введите идентификатор посетителя", "Ок");
                return;
            }

            
            if (visitorId.StartsWith("A"))
            {
                AllowButton.IsEnabled = true;
                DenyButton.IsEnabled = true;
                DisplayAlert("Доступ", "Доступ разрешен", "Ок");
            }
            else
            {
                AllowButton.IsEnabled = false;
                DenyButton.IsEnabled = true;
                DisplayAlert("Доступ", "Доступ запрещен", "Ок");
            }
        }

        private void OnAllowAccessClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Доступ", "Доступ разрешен", "Ок");
        }

        private void OnDenyAccessClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Доступ", "Доступ запрещен", "Ок");
        }
    }
}
