using LogoQuiz.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LogoQuiz
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("DetailPage", typeof(DetailPage));
        }

        private void RateApp_Click(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Rate!", "You selected the Rate This App menu item.", "Ok");
        }
    }
}
