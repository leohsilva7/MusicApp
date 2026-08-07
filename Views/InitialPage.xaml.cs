namespace MusicApp.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("RegisterPage");
    }
}