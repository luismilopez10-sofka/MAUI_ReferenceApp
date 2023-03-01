namespace MAUI_ReferenceApp.View;

public partial class VolumenPage : ContentPage
{
	public VolumenPage(VolumenViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}