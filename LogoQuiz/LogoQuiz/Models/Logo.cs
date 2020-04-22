﻿using LogoQuiz.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LogoQuiz.Models
{
    public class Logo : INotifyPropertyChanged
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Hint { get; set; }

        public Logo()
        {
            Id = Helper.GetRandomGUID();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
