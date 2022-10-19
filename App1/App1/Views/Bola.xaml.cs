﻿using AudioPlayEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bola : ContentPage
    {
        public Bola()
        {
            InitializeComponent();
            DependencyService.Get<IAudio>().PlayAudioFile("BOLA.m4a");
        }
        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await DisplayAlert("Correct", "Congratulations!", "OK");
                await Navigation.PushAsync(new Bibe());
            }
            else
            {
                DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
                await DisplayAlert("Sorry", "Try Again", "OK");
                await Navigation.PushAsync(new Bibe());
            }
        }
    }
}