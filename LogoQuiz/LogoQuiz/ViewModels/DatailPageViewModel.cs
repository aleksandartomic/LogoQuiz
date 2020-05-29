using LogoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace LogoQuiz.ViewModels
{
    [QueryProperty("Id", "Id")]
    [QueryProperty("Level", "Level")]
    public class DatailPageViewModel : BaseViewModel
    {
        private string id;
        public string Id
        {
            set { SetProperty(ref id, Uri.UnescapeDataString(value)); }
            get { return id; }
        }

        private string level;
        public string Level
        {
            set { SetProperty(ref level, Uri.UnescapeDataString(value)); }
            get { return level; }
        }

        public string LogoName { get; set; }
        public int Position { get; set; }
        public Logo Logo { get; set; }
        public ObservableCollection<Logo> Logos { get; set; }
        public ObservableCollection<Logo> LevelLogos { get; set; }
        public ICommand HintCommand { get; set; }
        public ICommand SuccessCommand { get; set; }
        public ICommand PositionChangedCommand { get; set; }


        public DatailPageViewModel()
        {
            HintCommand = new Command(Hint);

            SuccessCommand = new Command(Success);

            PositionChangedCommand = new Command(PositionChanged);
        }

        public async override void OnNavigatedTo(object parameters)
        {
            Logos = new ObservableCollection<Logo>(await Repository.GetLogosAsync());

            Logo = await Repository.GetLogoAsync(id.ToString());

            LogoList();
        }

        public void PositionChanged()
        {
            LogoName = null;
        }
        public void LogoList()
        {
            LevelLogos = new ObservableCollection<Logo>(
                         from logo in Logos
                         where Level == logo.Level
                         select logo);
        }

        public async void Hint() 
        {
            await Shell.Current.DisplayAlert("Hint", Logo.Hint, "OK");
        }

        public async void Success()
        {
            var duration = TimeSpan.FromSeconds(0.5);

            if (LogoName != null)
            {
                var entry = Regex.Replace(LogoName, @"\s+", "");
                var logoName = Regex.Replace(Logo.Name, @"\s+", "");

                if (logoName.ToLower() == entry.ToLower())
                {
                    Vibration.Vibrate(duration);
                    await Shell.Current.DisplayAlert("Ok", "Ok", "Ok");
                    Logo.IsSucceed = true;
                    Logo.Point = 5;

                    LogoName = null;

                    if (Position == LevelLogos.Count - 1)
                    {
                        Position = 0;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        Position++;
                    }
                }
                else
                {
                    await Shell.Current.DisplayAlert("No", "No", "Ok");
                }
            }
        }
    }
}
