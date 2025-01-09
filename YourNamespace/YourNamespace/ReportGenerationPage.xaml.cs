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
           
            if (ReportTypePicker.SelectedItem == null)
            {
                await DisplayAlert("Ошибка", "Пожалуйста, выберите тип отчета", "OK");
                return; 
            }

            
            if (StartDatePicker.Date == null || EndDatePicker.Date == null)
            {
                await DisplayAlert("Ошибка", "Пожалуйста, выберите период отчета", "OK");
                return; 
            }

            string reportType = ReportTypePicker.SelectedItem.ToString();
            DateTime startDate = StartDatePicker.Date;
            DateTime endDate = EndDatePicker.Date;

            
            await DisplayAlert("Отчет", $"Отчет типа {reportType} с {startDate.ToShortDateString()} по {endDate.ToShortDateString()}", "OK");
        }

        private async void OnSaveReportClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Отчет", "Отчет успешно сохранен", "OK");
        }




    }
}
