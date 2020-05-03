using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Twisun.Prism.ViewModels
{
    public class SolarPointsPageViewModel : ViewModelBase
    {
        public SolarPointsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Solar Points";
        }
    }
}
