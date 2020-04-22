using System;
using System.Collections.Generic;
using System.Text;

namespace LogoQuiz.Interfaces
{
    public interface INavigationAware
    {
        void OnNavigatedFrom(object parameters);

        void OnNavigatedTo(object parameters);
    }
}
