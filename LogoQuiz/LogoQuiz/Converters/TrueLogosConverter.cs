using LogoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LogoQuiz.Converters
{
    public class TrueLogosConverter : IValueConverter
    {
        public ObservableCollection<Logo> Logos { get; set; }
        public int TrueLogos { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Logos = (ObservableCollection<Logo>)value;

            string param = parameter.ToString();

            var LevelLogos = from logo in Logos
                    where param == logo.Level
                    select logo;

            var trueLogos = from logo in LevelLogos
                            where logo.IsSucceed == true
                            select logo;

            TrueLogos = trueLogos.Count();

            return String.Format($"{TrueLogos}/20");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
