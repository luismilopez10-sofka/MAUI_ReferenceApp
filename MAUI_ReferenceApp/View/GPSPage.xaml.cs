namespace MAUI_ReferenceApp.View;

public partial class GPSPage : ContentPage
{
	public GPSPage(GPSViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}