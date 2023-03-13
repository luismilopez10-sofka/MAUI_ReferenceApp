namespace MAUI_ReferenceApp.ViewModel;

public partial class SlidersChecksViewModel : BaseViewModel
{
    #region VARIABLES
    #endregion

    #region PROPERTIES
    [ObservableProperty]
    private bool enableSetImageSize = false;
    [ObservableProperty]
    private double imageSize = 1;
    #endregion

    #region CONSTRUCTORS
    public SlidersChecksViewModel()
    {
        Title = "Sliders & Checks";
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    public void PrintImageSize()
    {
        Debug.WriteLine(ImageSize);
    }
    #endregion
}
