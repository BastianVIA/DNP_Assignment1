using System;

namespace Entities {
    [Serializable]
public class Adult : Person{
    public Job JobTitle { get; set; }
}
}