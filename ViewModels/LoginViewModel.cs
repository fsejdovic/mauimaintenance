using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MAUI.MaintenanceApp.ViewModels
{
    //TODO: Use MVVM Community Toolkit...
    internal partial class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {

        }

        private string _firstName;
        private string _lastName;
        private string _userEmail;
        private bool _isLogin;
        private bool _isExistingAccountChecked;
        private bool _isNewAccountChecked;
        private string _password;

        public bool IsExistingAccountChecked
        {
            get
            {
                return _isExistingAccountChecked;
            }
            set
            {
                _isExistingAccountChecked = value;
                OnPropertyChanged(nameof(IsExistingAccountChecked));
            }
        }

        public bool IsNewAccountChecked
        {
            get
            {
                return _isNewAccountChecked;
            }
            set
            {
                _isNewAccountChecked = value;
                OnPropertyChanged(nameof(IsNewAccountChecked));
            }
        }

        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            set 
            { 
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string UserEmail
        {
            get
            {
                return _userEmail;
            }
            set
            {
                _userEmail = value;
                OnPropertyChanged(nameof(UserEmail));
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public void Reset()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            UserEmail = string.Empty;
            Password = string.Empty;
        }

        [RelayCommand]
        public void LoginMaintenance()
        {
            if (string.IsNullOrEmpty(Password))
                return;
          //TODO: Implement login algo...
        }
    }
}
