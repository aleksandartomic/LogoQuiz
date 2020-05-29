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

            string c = parameter.ToString();

            var a = from logo in Logos
                    where c == logo.Level
                    select logo;

            var trueLogos = from logo in a
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
