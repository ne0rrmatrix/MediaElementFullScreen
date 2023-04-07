namespace MediaElementFullScreen.Views;

public partial class MainPage : ContentPage
{
    private  bool s_fullScreen = false;
    public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
      
    }
    private void BtnFullScreen_Clicked(object sender, EventArgs e)
    {
        if (s_fullScreen)
        {
            s_fullScreen = false;
            btnFullScreen.Text = "Full Screen";
            mediaElement.RestoreScreen();
        }
        else
        {
            mediaElement.FullScreen();
            btnFullScreen.Text = "Restore Screen";
            s_fullScreen = true;
        }
    }
}
