using System;

namespace Entities
{
    [Serializable]
    public class Job
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}