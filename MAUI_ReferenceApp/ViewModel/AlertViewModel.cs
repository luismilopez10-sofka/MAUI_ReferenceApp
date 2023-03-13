using MAUI_ReferenceApp.View;

namespace MAUI_ReferenceApp.ViewModel;

public partial class AlertViewModel : BaseViewModel
{
    #region VARIABLES
    #endregion

    #region PROPERTIES
    #endregion

    #region CONSTRUCTORS
    public AlertViewModel()
    {
        Title = "Alerts";
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    private async Task ShowAlert()
    {
        await Shell.Current.DisplayAlert("Título", "Este es el contenido de la alerta", "Ok", "Cancelar");
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Shell.Current.GoToAsync($"..");
    }
    #endregion
}