using System.Collections.ObjectModel;

namespace MAUI_ReferenceApp.ViewModel;

public partial class InfiniteScrollViewModel : BaseViewModel
{
    #region VARIABLES
    int lastId;
    static string baseUrl = "https://picsum.photos/500/300?image=";
    #endregion

    #region PROPERTIES
    public ObservableCollection<string> ImagesIds { get; } = new ObservableCollection<string>(
    Enumerable.Range(1, 10)
        .Select(i => $"{baseUrl}{i}")
        .ToList());

    [ObservableProperty]
    bool isRefreshing = false;
    #endregion

    #region CONSTRUCTORS
    public InfiniteScrollViewModel()
    {
        Title = "Infinite Scroll & Pull Refresh";
        lastId = ImagesIds.Count;
    }
    #endregion

    #region COMMANDS
    [RelayCommand]
    void FetchData()
    {
        if (IsBusy)
            return;

        IsBusy = true;

        Add5();

        IsBusy = false;
    }

    [RelayCommand]
    void Refresh()
    {
        ImagesIds.Clear();
        ImagesIds.Add($"{baseUrl}{this.lastId + 1}");
        Add5(lastId: this.lastId + 1);

        IsRefreshing = false;
    }
    #endregion

    #region METHODS
    void Add5(int lastId = 0)
    {
        if (lastId == 0)
        {
            lastId = this.lastId;
            this.lastId += 5;
        }
        else
        {
            this.lastId += 6;
        }

        foreach (int i in new[]{1, 2, 3, 4, 5})
        {
            ImagesIds.Add($"{baseUrl}{i + lastId}");
        }
    }
    #endregion
}