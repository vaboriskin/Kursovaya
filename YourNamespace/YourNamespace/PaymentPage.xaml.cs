using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace YourNamespace
{
    public partial class PaymentPage : ContentPage
    {
        public PaymentPage()
        {
            InitializeComponent();

            
            List<string> paymentMethods = new List<string>
            {
                "Наличные",
                "Банковская карта",
                "СБП"
            };

            
            PaymentMethodPicker.ItemsSource = paymentMethods;
        }

        private async void OnPayClicked(object sender, EventArgs e)
        {
            
            if (PaymentMethodPicker.SelectedItem == null)
            {
                await DisplayAlert("Ошибка", "Пожалуйста, выберите метод оплаты", "OK");
                return; 
            }

            
            string selectedPaymentMethod = PaymentMethodPicker.SelectedItem.ToString();

            
            await DisplayAlert("Оплата", $"Оплата выполнена через {selectedPaymentMethod}", "OK");
        }


    }
}
