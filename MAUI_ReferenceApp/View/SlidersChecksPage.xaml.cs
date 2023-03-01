namespace MAUI_ReferenceApp.View;

public partial class SlidersChecksPage : ContentPage
{
	public SlidersChecksPage(SlidersChecksViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}