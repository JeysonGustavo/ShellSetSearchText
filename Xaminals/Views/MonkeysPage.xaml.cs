﻿using System;
using System.Linq;
using Xamarin.Forms;
using Xaminals.Models;

namespace Xaminals.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
            InitializeComponent();

            // It works well.
            //searchMonkey.Query = "Test";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // It works well.
            //searchMonkey.Query = "Test";
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string monkeyName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"monkeydetails?name={monkeyName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/monkeys/monkeydetails?name={monkeyName}");
        }

        private void btnFillSearch_Clicked(object sender, EventArgs e)
        {
            //It does not work.
            searchMonkey.Query = "Test";
        }
    }
}
