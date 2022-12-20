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
	public partial class AlpabeBonusGameLetterI : ContentPage
	{
		public AlpabeBonusGameLetterI()
		{
			InitializeComponent ();
		}

        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new AlpabeBonusGameLetterI2(), false);
            }
            else
            {
              
                await DisplayAlert("Sorry", "Try Again", "OK");
               
            }
        }
    }
}