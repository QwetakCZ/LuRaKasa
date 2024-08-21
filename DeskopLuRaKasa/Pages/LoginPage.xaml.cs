using DeskopLuRaKasa.Services;
using DeskopLuRaKasa.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeskopLuRaKasa.Pages
{
    /// <summary>
    /// Interakční logika pro LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        LoginViewModel _loginViewModel;
        SendRequestAPI sendRequestAPI;
        public LoginPage(GlobalViewModel g)
        {
            _loginViewModel = new LoginViewModel(g);
            sendRequestAPI = new SendRequestAPI(g);
            this.DataContext = _loginViewModel;
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            labelLogin.Content = String.Empty;
            _loginViewModel._globalModel.IsLoading = !_loginViewModel._globalModel.IsLoading;
            var userIdText = await sendRequestAPI.LoginToStringAsync(_loginViewModel.Login, _loginViewModel.Password);
            if (userIdText != _loginViewModel._globalModel.LoginFailed)
            {
                SetUserId(userIdText);

            }
            else
            {
                SetUserId();
            }

            _loginViewModel._globalModel.IsLoading = !_loginViewModel._globalModel.IsLoading;

        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            _loginViewModel._globalModel.UserId = String.Empty;
            IsolatedStorageServices.Set("UserId", String.Empty);
        }

        private void SetUserId(string? userId = "")
        { 
         
         
                IsolatedStorageServices.Set("UserId", userId);
                _loginViewModel._globalModel.UserId = userId;
                _loginViewModel.Login = String.Empty;
                _loginViewModel.Password = String.Empty;
                labelLogin.Content = userId != "" ? "Přihlášení proběhlo úspěšně" : _loginViewModel._globalModel.LoginFailed;
                
         
        }
    }
}
