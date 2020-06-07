using LogoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LogoQuiz.ViewModels
{
    [QueryProperty("Level", "Level")]
    class ListLogosViewModel : BaseViewModel
    {
        private string level;
        public string Level
        {
            set { SetProperty(ref level, Uri.UnescapeDataString(value)); }
            get { return level; }
        }
        public ObservableCollection<Logo> Logos { get; set; }
        public ObservableCollection<Logo> LevelLogos { get; set; }

        public ICommand NavigateToDetailPageCommand { get; set; }

        public ListLogosViewModel()
        {
            NavigateToDetailPageCommand = new Command(NavigateToDetailPage);
        }
        public async override void OnNavigatedTo(object parameters)
        {
            Logos = new ObservableCollection<Logo>(await Repository.GetLogosAsync());

            LogoList();
        }

        public void LogoList()
        {
            LevelLogos = new ObservableCollection<Logo>(
                         from logo in Logos
                         where Level == logo.Level
                         select logo);
        }

        public async void NavigateToDetailPage(object id)
        {
            await Shell.Current.GoToAsync($"/LogoPage?Id={id}&Level={Level}");
        }
    }
}
