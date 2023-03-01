namespace MAUI_ReferenceApp.Broker.User;

public interface IBrkUser
{
    Task<string> Login(MdlUser objMdlUser);
    Task<string> CreateUser(MdlUser objMdlUser);
}