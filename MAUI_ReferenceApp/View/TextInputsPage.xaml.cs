namespace MAUI_ReferenceApp.View;

public partial class TextInputsPage : ContentPage
{
	public TextInputsPage(TextInputsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}