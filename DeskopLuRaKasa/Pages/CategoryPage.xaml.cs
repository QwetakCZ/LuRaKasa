using DeskopLuRaKasa.Models;
using DeskopLuRaKasa.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interakční logika pro CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        
        GlobalViewModel _globalModel;

        public CategoryPage(GlobalViewModel g)
        {
            _globalModel = g;
            InitializeComponent();
            

            
           

        }
    }
}
