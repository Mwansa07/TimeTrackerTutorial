using System;
using System.Windows.Input;
using TimeTrackerTutorial.PageModels.Base;
using TimeTrackerTutorial.Services.Navigation;
using Xamarin.Forms;

namespace TimeTrackerTutorial.PageModels
{
    public class LoginPageModel : PageModelBase
    {
        private ICommand _loginCommand;

        public ICommand LoginCommand
        {
            get => _loginCommand;
            set => SetProperty(ref _loginCommand, value);
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private INavigationService _navigationService;
        public LoginPageModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new Command(OnSignInAction);
        }

        private void OnSignInAction(object obj)
        {
            _navigationService.NavigateToAsync<DashboardPageModel>();
        }
    }
}
