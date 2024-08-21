using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskopLuRaKasa.Models;
using DeskopLuRaKasa.Services;

namespace DeskopLuRaKasa.ViewModels
{
    public class GlobalViewModel : NotifyProperty
    {
        private string _userId = string.Empty;
        public string UserId
        {
            get => _userId;
            set
            {
                _userId = value;
                OnPropertyChanged();
            }
        }

        private bool _isLoading = false;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }


        private const string loginFailed = "Přihlášení se nezdařilo";

        public string LoginFailed => loginFailed;


       
    }
}
