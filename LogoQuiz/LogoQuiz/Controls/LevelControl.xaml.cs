using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogoQuiz.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LevelControl : ContentView
    {
        public LevelControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty LevelTextProperty = BindableProperty.Create(nameof(LevelText), typeof(string), typeof(LevelControl), string.Empty);
        public string LevelText
        {
            get { return (string)GetValue(LevelTextProperty); }
            set { SetValue (LevelTextProperty, value); }
        }

        public static readonly BindableProperty NavigateCommandProperty = BindableProperty.Create(nameof(NavigateCommand), typeof(ICommand), typeof(LevelControl), null);
        public ICommand NavigateCommand
        {
            get { return (ICommand)GetValue(NavigateCommandProperty); }
            set { SetValue(NavigateCommandProperty, value); }
        }

        public static readonly BindableProperty IconFontProperty = BindableProperty.Create(nameof(IconFont), typeof(string), typeof(LevelControl), string.Empty);
        public string IconFont
        {
            get { return (string)GetValue(IconFontProperty); }
            set { SetValue(IconFontProperty, value); }
        }

        public static readonly BindableProperty FormattedTextProperty = BindableProperty.Create(nameof(FormattedText), typeof(string), typeof(LevelControl), string.Empty);
        public string FormattedText
        {
            get { return (string)GetValue(FormattedTextProperty); }
            set { SetValue(FormattedTextProperty, value); }
        }

        public static readonly BindableProperty VisibleProperty = BindableProperty.Create(nameof(Visible), typeof(bool), typeof(LevelControl), false);
        public bool Visible
        {
            get { return (bool)GetValue(VisibleProperty); }
            set { SetValue(VisibleProperty, value); }
        }

        public static readonly BindableProperty IsEnableProperty = BindableProperty.Create(nameof(IsEnable), typeof(bool), typeof(LevelControl), false);
        public bool IsEnable
        {
            get { return (bool)GetValue(IsEnableProperty); }
            set { SetValue(IsEnableProperty, value); }
        }
    }
}