using System.Collections.Generic;
using Entities;


namespace Server.Persistence
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}