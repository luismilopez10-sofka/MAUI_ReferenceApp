using MAUI_ReferenceApp.Services;
using System.Collections.ObjectModel;

namespace MAUI_ReferenceApp.ViewModel;

public partial class CollectionViewModel : BaseViewModel
{
    #region VARIABLES
    MonkeyService monkeyService;
    #endregion

    #region PROPERTIES
    public ObservableCollection<MdlMonkey> Monkeys { get; } = new();
    #endregion

    #region CONSTRUCTORS
    public CollectionViewModel(MonkeyService monkeyService)
    {
        Title = "Collections";
        this.monkeyService = monkeyService;
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    async Task GetMonkeysAsync()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var monkeys = await monkeyService.GetMonkeys();

            if (Monkeys.Count != 0)
                Monkeys.Clear();

            foreach (var monkey in monkeys)
                Monkeys.Add(monkey);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
    #endregion
}
