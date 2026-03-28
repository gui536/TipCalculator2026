namespace TipCalculator;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();
	}

    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
		Launcher.OpenAsync("https://etechoracio.com.br/etechas/");
    }
}