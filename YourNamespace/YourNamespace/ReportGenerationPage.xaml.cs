using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace YourNamespace
{
    public partial class ReportGenerationPage : ContentPage
    {
        public ReportGenerationPage()
        {
            InitializeComponent();

            
            List<string> reportTypes = new List<string>
            {
                "По клиентам",
                "По результатам стрельбы",
                "По оплатам"
            };

            
            ReportTypePicker.ItemsSource = reportTypes;
        }

        private async void OnGenerateReportClicked(object sender, EventArgs e)
        {
            string reportType = ReportTypePicker.SelectedItem?.ToString();

           
            if (StartDatePicker.Date > EndDatePicker.Date)
            {
                await DisplayAlert("Ошибка", "Дата начала не может быть позже даты конца", "Ок");
                return;
            }

            
            await DisplayAlert("Отчет", $"Тип отчета: {reportType}\nПериод: {StartDatePicker.Date.ToShortDateString()} - {EndDatePicker.Date.ToShortDateString()}", "Ок");
        }

        private async void OnSaveReportClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Отчет", "Отчет сохранен", "Ок");
        }
    }
}
