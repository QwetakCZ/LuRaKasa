using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskopLuRaKasa.Services;

namespace DeskopLuRaKasa.ViewModels
{
    public class LoginViewModel : NotifyProperty
    {
        public GlobalViewModel _globalModel;

        public LoginViewModel(GlobalViewModel g)
        {
            _globalModel = g;
        }

        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }


    }
}
