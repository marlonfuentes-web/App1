﻿using Android.App;
using Android.Content.PM;
using Android.Media;
using App1.Services;
using App1.ViewModels;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
      
        public AboutPage()
        {
            InitializeComponent();
            //DependencyService.Get<IAudio>().PlayAudioFile("MusicBG.mp3");
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage());

            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");

            DependencyService.Get<IAudio>().PlayAudioFile("Quick.wav");
        }





        
    }

}
