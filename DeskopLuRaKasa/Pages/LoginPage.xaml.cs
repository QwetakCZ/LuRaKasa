using DeskopLuRaKasa.Services;
using DeskopLuRaKasa.ViewModels;
using System;
using System.Collections.Generic;
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
        public LoginPage(GlobalViewModel g)
        {
            _loginViewModel = new LoginViewModel(g);
            this.DataContext = _loginViewModel;
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5195/");
            var text = await client.GetStringAsync($"User/Login?username=admin@admin.cz&password=neznam");
            IsolatedStorageServices.Set("UserId", text);
        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
