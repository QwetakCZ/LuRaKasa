using MobileLuRaKasa.ViewModels;
namespace MobileLuRaKasa.Views;

public partial class SettingsPage : ContentPage
{
    private string _username = string.Empty;

    public SettingsPage()
    {
        InitializeComponent();
        BindingContext = new GlobalViewModel();
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://192.168.68.105:5195");
        var text = client.GetStringAsync("User/Ahoj").Result;
        label.Text = text;
        OnAppearing();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewModel = (GlobalViewModel)this.BindingContext;
        label.Text = viewModel.Result;
    }
}
