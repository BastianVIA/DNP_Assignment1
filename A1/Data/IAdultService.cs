using System.Collections.Generic;
using Models;

namespace A1.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void AddJob(Job job);
    }
}