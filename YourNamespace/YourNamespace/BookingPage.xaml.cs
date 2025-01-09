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
{ string trainingType = TrainingTypePicker.SelectedItem.ToString();
	DateTime selectedDate = DatePicker.Date;
	TimeSpan selectedTime = TimePicker.Time;
	await DisplayAlert("Успех", $"Тренировка успешно забронирована на {selectedDate.ToShortDateString()} в {selectedTime}", "OK"); }

    }
}
