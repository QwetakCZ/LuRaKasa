﻿using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using DeskopLuRaKasa.Data;

namespace DeskopLuRaKasa
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using (var context = new LocalDBContext())
            {
                context.Database.Migrate();
            }
           
        }
    }

}
