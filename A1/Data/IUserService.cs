using Models;

namespace A1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}