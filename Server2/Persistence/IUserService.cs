using System.Collections.Generic;
using Entities;

namespace Server2.Persistence
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}