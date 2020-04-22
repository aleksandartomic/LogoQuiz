using LogoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LogoQuiz.ViewModels
{
    [QueryProperty("Id", "Id")]
    public class DatailPageViewModel : BaseViewModel
    {
        public string LogoName { get; set; }

        public int Position { get; set; }

        private string id;
        public string Id
        {
            set { SetProperty(ref id, Uri.UnescapeDataString(value)); }
            get { return id; }
        }

        public Logo Logo { get; set; }
        public ObservableCollection<Logo> Logos { get; set; }

        public ICommand HintCommand { get; set; }

        public ICommand SuccessCommand { get; set; }

        public DatailPageViewModel()
        {
            HintCommand = new Command(Hint);

            SuccessCommand = new Command(Success);
        }

        public async override void OnNavigatedTo(object parameters)
        {
            Logo = await Repository.GetLogoAsync(id.ToString());

            Logos = new ObservableCollection<Logo>(await Repository.GetLogosAsync());
        }

        public async void Hint() 
        {
            await Shell.Current.DisplayAlert("Hint", Logo.Hint, "OK");
        }

        public async void Success()
        {
            if (Logo.Name.ToLower() == LogoName.ToLower())
            {
                await Shell.Current.DisplayAlert("Ok", "Ok", "Ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("No", "No", "Ok");
            }
        }
    }
}
