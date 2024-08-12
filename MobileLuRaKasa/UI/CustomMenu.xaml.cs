using MobileLuRaKasa.Views;
namespace MobileLuRaKasa.UI;

public partial class CustomMenu : ContentView
{
	public CustomMenu()
	{
		InitializeComponent();
        btnBack.IsVisible = false;
	}

    

    private void btnBack_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private async void btnSettings_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    public bool IsBackButtonVisible
    {
        get { return btnBack.IsVisible; }
        set { btnBack.IsVisible = value; }
    }

    public bool IsSettingsButtonVisible
    {
        get { return btnSettings.IsVisible; }
        set { btnSettings.IsVisible = value; }
    }

    public bool IsTitleVisible
    {
        get { return LabelBarTitle.IsVisible; }
        set { LabelBarTitle.IsVisible = value; }
    }

    public bool IsLogoVisible
        {
        get { return imgLogo.IsVisible; }
        set { imgLogo.IsVisible = value; }
    }
}