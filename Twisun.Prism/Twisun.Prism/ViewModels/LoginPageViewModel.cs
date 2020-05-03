using Prism.Commands;
using Prism.Navigation;
using System;

namespace Twisun.Prism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _password;
        private bool _isRunning;
        private bool _isEnabled;
        private DelegateCommand _loginCommand;

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Login";
            IsEnabled = true;
            _navigationService = navigationService;
        }

        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));       

        public string Email { get; set; }
        public string Password 
        { 
            get { return _password; } 
            set => SetProperty(ref _password, value); 
        }

        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        private async void Login()
        {
           if (string.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter an email.", "Accept");
                return;
            }

           if (string.IsNullOrEmpty(Password))
           {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter a password.", "Accept");
                return;
           }
            Password = string.Empty;
           await _navigationService.NavigateAsync("TwisunTabbedPage");
        }
    }
}
