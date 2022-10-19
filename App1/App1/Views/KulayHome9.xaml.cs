﻿using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome9 : ContentPage
    {
      
        public KulayHome9()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
            await Navigation.PushAsync(new KulayHome9v2());

        }
        async void OnDrop(object sender, DropEventArgs e)
        {

            await DisplayAlert("Correct", "Congratulations!", "OK");
            await Navigation.PushAsync(new KulayHome9v2());

        }


    }
}