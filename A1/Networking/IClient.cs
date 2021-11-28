using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace A1.Networking
{
    public interface IClient
    {
        Task<IList<Adult>> ReadData();
        Task SaveChanges(IList<Adult> adults);
        Task<IList<User>> GetUsers();
    }
}