using System;
using Xamarin.Forms;

namespace YourNamespace
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Регистрация", "Регистрация успешна", "Ок");

            
            await Navigation.PushAsync(new BookingPage());
        }

        private async void OnGoToPaymentPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaymentPage());
        }

        private async void OnGoToReportPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportGenerationPage());
        }

        private async void OnGoToAccessControlPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccessControlPage());
        }

    }
}
