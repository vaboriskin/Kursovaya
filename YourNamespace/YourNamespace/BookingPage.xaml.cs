using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace YourNamespace
{
    public partial class BookingPage : ContentPage
    {
        public BookingPage()
        {
            InitializeComponent();

            
            List<string> trainingTypes = new List<string>
            {
                "Групповая",
                "Индивидуальная"
            };
            TrainingTypePicker.ItemsSource = trainingTypes;

            
            List<string> trainers = new List<string>
            {
                "Тренер 1",
                "Тренер 2",
                "Автоматически"
            };
            TrainerPicker.ItemsSource = trainers;
        }

        private async void OnConfirmBookingClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Бронирование", "Тренировка забронирована", "Ок");
        }
    }
}
