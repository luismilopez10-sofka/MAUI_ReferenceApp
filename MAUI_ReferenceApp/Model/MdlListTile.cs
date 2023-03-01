namespace MAUI_ReferenceApp.Model;

public class MdlListTile
{
    public string Icon { get; set; }
    public string Title { get; set; }

    public MdlListTile()
    {
    }

    public MdlListTile(string icon, string title)
    {
        Icon = icon;
        Title = title;
    }
}
