using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace A1.Models
{
    public interface IAdultService
    {
        Task<IList<Adult>> ReadData();
        Task SaveChanges(IList<Adult> adults);
    }
}