﻿using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kulay20 : ContentPage
    {
      
        public Kulay20()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(2500); await this.Navigation.PushAsync(new Kulay21(), false); }

        private async void OnDrop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kulay21(), false);
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}