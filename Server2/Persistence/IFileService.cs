using System.Collections.Generic;
using Entities;

namespace Server2.Persistence
{
    public interface IFileService
    {
        IList<T> ReadData<T>(string s);
        void SaveChanges(IList<Adult> adults);

    }
}