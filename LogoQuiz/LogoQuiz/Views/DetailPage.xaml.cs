﻿using LogoQuiz.ViewModels;
using LogoQuiz.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogoQuiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : BasePage
    {
        public DetailPage()
        {
            InitializeComponent();

            BindingContext = new DatailPageViewModel();
        }
    }
}