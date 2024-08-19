using DeskopLuRaKasa.Models;
using DeskopLuRaKasa.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskopLuRaKasa.ViewModels
{
    internal class CategoryViewModel : NotifyProperty
    {
        GlobalViewModel Global { get; set; }

        public CategoryViewModel(GlobalViewModel g)
        { 
            Global = g;
        }

        private ObservableCollection<Category> _categories;
        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                OnPropertyChanged();
            }
        }
    }
}
