using System;

namespace Entities
{
    [Serializable]
    public class User
    {
        public string UserName { get; set; }
        public int SecurityLevel { get; set; } 
        public string Password { get; set; }
    }
}