namespace MAUI_ReferenceApp.ViewModel;

public partial class TextInputsViewModel : BaseViewModel
{
    #region VARIABLES
    #endregion

    #region PROPERTIES
    [ObservableProperty]
    private string name;
    [ObservableProperty]
    private string comment;
    #endregion

    #region CONSTRUCTORS
    public TextInputsViewModel()
    {
        Title = "Text Inputs";
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    private async Task ValidateFieldsAsync()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            await Shell.Current.DisplayAlert("Validación", "Por favor ingrese su nombre", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(Comment))
        {
            await Shell.Current.DisplayAlert("Validación", "Por favor ingrese su comentario", "OK");
        }
    }
    #endregion
}