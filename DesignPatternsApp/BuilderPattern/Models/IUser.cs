using System;

namespace PrototypePattern.Models
{
    public interface IUser : ICloneable
    {
        string Name { get; }
        int Age{ set; } 
        string Address { get; }
    }
}
