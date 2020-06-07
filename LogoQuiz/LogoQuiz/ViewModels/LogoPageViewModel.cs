using LogoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LogoQuiz.ViewModels
{
    [QueryProperty("Id", "Id")]
    [QueryProperty("Level", "Level")]
    class LogoPageViewModel : BaseViewModel
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

        public int HintCount { get; set; }
        public string LogoName { get; set; }
        public int Position { get; set; }
        public Logo Logo { get; set; }
        public ObservableCollection<Logo> Logos { get; set; }
        public ObservableCollection<Logo> LevelLogos { get; set; }
        public ICommand HintCommand { get; set; }
        public ICommand SuccessCommand { get; set; }
        public ICommand PositionChangedCommand { get; set; }

        public int ClickHint { get; set; }
        public LogoPageViewModel()
        {
            HintCommand = new Command(Hint);

            SuccessCommand = new Command(Success);

            PositionChangedCommand = new Command(PositionChanged);

            HintCount = Preferences.Get("HintCount", 50);
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

            ClickHint = 0;
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
            if (HintCount > 0)
            {
                switch (ClickHint)
                {
                    case 0:
                        string FirstCharLogo = Logo.Name.Substring(0, 1);
                        LogoName = FirstCharLogo;
                        ClickHint++;
                        HintCount--;
                        break;
                    case 1:
                        string SecoundCharLogo = Logo.Name.Substring(0, 2);
                        LogoName = SecoundCharLogo;
                        ClickHint++;
                        HintCount--;
                        break;
                    case 2:
                        string ThreeCharLogo = Logo.Name.Substring(0, 3);
                        LogoName = ThreeCharLogo;
                        ClickHint++;
                        HintCount--;
                        break;
                    case 3:
                        string FourCharLogo = Logo.Name.Substring(0, 4);
                        LogoName = FourCharLogo;
                        ClickHint++;
                        HintCount--;
                        break;
                    case 4:
                        string FiveCharLogo = Logo.Name.Substring(0, 5);
                        LogoName = FiveCharLogo;
                        ClickHint++;
                        HintCount--;
                        break;
                    case 5:
                        LogoName = Logo.Name;
                        ClickHint++;
                        HintCount--;
                        Success();
                        break;
                    default:
                        break;
                }

                Preferences.Set("HintCount", HintCount);
            }

            if (HintCount == 0)
            {
                await Shell.Current.DisplayAlert("Hint", "You don't have hints, any more!", "OK");
            }
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
                    Logo.IsSucceed = true;
                    Logo.Point = 5;
                    Repository.Save();
                    AddHint();

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
                    await Shell.Current.DisplayAlert("Not Hit", "You didn't guess!", "Try Again");
                }
            }
        }

        public void AddHint()
        {
            var SumLogos = Logos.Sum(item => item.Point);
            if (SumLogos == 75 || SumLogos == 150 || SumLogos == 225 || SumLogos == 300 || SumLogos == 375)
            {
                HintCount += 10;
                Preferences.Set("HintCount", HintCount);
            }
        }
    }
}
