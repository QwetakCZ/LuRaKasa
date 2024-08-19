using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DeskopLuRaKasa.Pages;
using DeskopLuRaKasa.Services;
using DeskopLuRaKasa.ViewModels;

namespace DeskopLuRaKasa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string _userId;
        private GlobalViewModel _globalModel = new GlobalViewModel();
        public MainWindow()
        {
            _userId = IsolatedStorageServices.Get("UserId");
            
           this.DataContext = _globalModel;
            _globalModel.UserId = _userId;

            InitializeComponent();

                    
             
        }

        private async void MenuLogin_Click(object sender, RoutedEventArgs e)
        {
            var loginPage = new LoginPage(_globalModel);
            MainFrame.Navigate(loginPage);
               
            
         
        }

        private void btn_OrderPage_Click(object sender, RoutedEventArgs e)
        {
            var orderPage = new OrdersPage(_globalModel);
            MainFrame.Navigate(orderPage);
        }

        private void btn_PayPage_Click(object sender, RoutedEventArgs e)
        {
            var payPage = new PayPage(_globalModel);
            MainFrame.Navigate(payPage);
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Categories_Click(object sender, RoutedEventArgs e)
        {
            var categoryPage = new CategoryPage(_globalModel);
            MainFrame.Navigate(categoryPage);
        }
    }
}