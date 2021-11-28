using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;


namespace Server.Persistence
{
    public interface IFileService
    {
        IList<T> ReadData<T>(string s);
        void SaveChanges(IList<Adult> adults);

    }
}