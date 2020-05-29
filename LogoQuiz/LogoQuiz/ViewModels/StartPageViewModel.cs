using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LogoQuiz.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        public ICommand NavigateToLevelsPageCommand { get; set; }
        public ICommand NavigateToSettingsPageCommand { get; set; }
        public ICommand QuitCommand { get; set; }

        public StartPageViewModel()
        {
            NavigateToLevelsPageCommand = new Command(NavigateToLevelsPage);

            NavigateToSettingsPageCommand = new Command(NavigateToSettingsPage);

            QuitCommand = new Command(Quit);
        }

        public async void NavigateToLevelsPage()
        {
            await Shell.Current.GoToAsync("LevelsPage");
        }

        public async void NavigateToSettingsPage()
        {
            await Shell.Current.GoToAsync("SettingsPage");
        }

        public void Quit()
        {
            Application.Current.Quit();
        }
    }
}
