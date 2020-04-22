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
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<Logo> Logos { get; set; }

        public ICommand NavigateToDetailPageCommand { get; set; }

        public HomePageViewModel()
        {
            NavigateToDetailPageCommand = new Command(NavigateToDetailPage);
        }
        public async override void OnNavigatedTo(object parameters)
        {
            Logos = new ObservableCollection<Logo> (await Repository.GetLogosAsync());
        }

        public async void NavigateToDetailPage(object id)
        {
            await Shell.Current.GoToAsync($"/DetailPage?Id={id}");
        }
    }
}
