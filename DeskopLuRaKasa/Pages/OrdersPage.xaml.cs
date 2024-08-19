using DeskopLuRaKasa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interakční logika pro OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        GlobalViewModel _globalModel;
        public OrdersPage(GlobalViewModel g)
        {
            _globalModel = g;
            InitializeComponent();
        }
    }
}
