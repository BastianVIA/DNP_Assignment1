using System.Threading.Tasks;
using Entities;

namespace A1.Models
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}