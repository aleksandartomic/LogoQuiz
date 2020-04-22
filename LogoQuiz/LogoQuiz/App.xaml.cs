using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LogoQuiz.Views;
using LogoQuiz.Models;
using DLToolkit.Forms.Controls;

namespace LogoQuiz
{
    public partial class App : Application
    {
        public static Repository Repository;
        public App(string dbPath)
        {
            InitializeComponent();
            FlowListView.Init();

            Repository = new Repository(dbPath);
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
