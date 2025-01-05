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
            
            string selectedMethod = PaymentMethodPicker.SelectedItem?.ToString();

            
            if (!string.IsNullOrEmpty(selectedMethod))
            {
                await DisplayAlert("Оплата", $"Вы выбрали метод: {selectedMethod}. Оплата прошла успешно!", "Ок");
            }
            else
            {
                await DisplayAlert("Ошибка", "Выберите метод оплаты", "Ок");
            }
        }
    }
}
