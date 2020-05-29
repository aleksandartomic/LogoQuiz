﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LogoQuiz.Converters
{
    public class OpenLevelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int points = System.Convert.ToInt32(value);

            if (parameter.ToString() == "Level 2" && points >= 5)
            {
                return true;
            }

            if (parameter.ToString() == "Level 3" && points >= 10)
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}