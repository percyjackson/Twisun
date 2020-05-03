using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Twisun.Prism.ViewModels
{
    public class GeneralPageViewModel : ViewModelBase
    {
        public GeneralPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "General";
        }
    }
}
