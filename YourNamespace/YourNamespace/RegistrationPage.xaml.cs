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
            string fullName = FullNameEntry.Text;
            string phoneNumber = PhoneNumberEntry.Text;
            string email = EmailEntry.Text;
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {
                await DisplayAlert("Ошибка", "Все поля должны быть заполнены", "OK");
                return;
            }
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
