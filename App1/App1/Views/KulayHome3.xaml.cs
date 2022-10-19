﻿using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome3 : ContentPage
    {
      
        public KulayHome3()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KulayHome4());
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}