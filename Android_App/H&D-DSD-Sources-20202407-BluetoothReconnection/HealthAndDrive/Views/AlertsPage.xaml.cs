using HealthAndDrive.Models.Enums;
using HealthAndDrive.ViewModels;
using System;
using Xamarin.Forms;

namespace HealthAndDrive.Views
{
    public partial class AlertsPage : ContentPage
    {
        public AlertsPage()
        {
            InitializeComponent();

            //Need for the focus management and cursor position
            MessagingCenter.Subscribe<AlertsPageViewModel, MaxMinFocusedEnum>(this, "FocusManagement", (sender, args) =>
            {
                if (args == MaxMinFocusedEnum.MaxFocused)
                {
                    MaxEntryFocused.Focus();
                    Console.WriteLine(MinEntryFocused.IsFocused);
                    MaxEntryFocused.CursorPosition = MaxEntryFocused.MaxLength;
                }
                else if(args == MaxMinFocusedEnum.MinFocused)
                {
                    MinEntryFocused.Focus();
                    Console.WriteLine(MinEntryFocused.IsFocused);
                    MinEntryFocused.CursorPosition = MinEntryFocused.MaxLength;
                }
            });
        }
    }
}
