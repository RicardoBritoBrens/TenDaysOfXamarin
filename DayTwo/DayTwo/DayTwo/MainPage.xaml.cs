﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DayTwo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entUsername.Text))
            {
                greetingLabel.Text = $"Hello {entUsername.Text}, welcome to 10 Days of Xamarin.";
            }
            else
            {
                DisplayAlert("Error", "Your name can't be empty", "Oh right");
            }
        }



    }
}