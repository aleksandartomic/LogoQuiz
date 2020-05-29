using LogoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LogoQuiz.ViewModels
{
    public class LevelsPageViewModel : BaseViewModel
    {
        public int Points { get; set; }
        public ObservableCollection<Logo> Logos { get; set; }
        public ICommand NavigateToHomePageCommand { get; set; }
        public LevelsPageViewModel()
        {
            NavigateToHomePageCommand = new Command(NavigateToHomePage);
            Aaa();
        }

        public async void Aaa()
        {
            Logos = new ObservableCollection<Logo>(await Repository.GetLogosAsync());
        }
        public async override void OnNavigatedTo(object parameters)
        {
            Logos = new ObservableCollection<Logo>(await Repository.GetLogosAsync());

            Points = Logos.Sum(item => item.Point);
        }

        public async void NavigateToHomePage(object parameters)
        {
            await Shell.Current.GoToAsync($"/HomePage?Level={parameters}");
        }
    }
}
