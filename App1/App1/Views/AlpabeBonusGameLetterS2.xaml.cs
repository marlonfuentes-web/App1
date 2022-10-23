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
	public partial class AlpabeBonusGameLetterS2 : ContentPage
	{
		public AlpabeBonusGameLetterS2()
		{
			InitializeComponent ();
		}

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Saging(), false);

            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");

            DependencyService.Get<IAudio>().PlayAudioFile("Quick.wav");
        }
    }
}