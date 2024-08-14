using MobileLuRaKasa.ViewModels;
using System.Diagnostics;
using MobileLuRaKasa.Services;
using Microsoft.AspNetCore.Identity;
using DTOLuRaKasa;
namespace MobileLuRaKasa.Views;


public partial class SettingsPage : ContentPage
{
    private string _username = string.Empty;
    

    public SettingsPage()
    {
        InitializeComponent();

        if (Preferences.ContainsKey("Api"))
        {
           entryApi.Text = Preferences.Get("Api", string.Empty);
        }

        else
        {
            entryApi.SetBinding(Entry.TextProperty, "Api");
        }

        
    }


    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(entryApi.Text);
        
        var text = await client.GetStringAsync($"User/Login?username={entryLogin.Text}&password={entryPassword.Text}");
        entryUserId.Text = text;
       

        
       
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        Preferences.Set("Api", entryApi.Text);

    }

 


  
}
