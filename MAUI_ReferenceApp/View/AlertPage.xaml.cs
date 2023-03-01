namespace MAUI_ReferenceApp.View;

public partial class AlertPage : ContentPage
{
    public AlertPage(AlertViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}