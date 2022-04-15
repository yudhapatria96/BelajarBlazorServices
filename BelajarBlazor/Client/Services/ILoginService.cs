namespace BelajarBlazor.Client.Services
{
    public interface ILoginService
    {
        User users { get; set; }  

        Task Login(User user);
    }
}
